using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public enum ColonistState
    {
        Idle,
        Wandering,
        WorkingAnimation
    }

    public class Colonist : MonoBehaviour
    {
        [Header("Identity")]
        public string colonistName;

        [Header("Movement")]
        public float moveSpeed = 3f;
        public float rotationSpeed = 120f;

        [Header("State")]
        public ColonistState currentState = ColonistState.Idle;

        private NavMeshAgent agent;
        private Animator animator;
        private List<Transform> wanderPoints;
        private Transform currentTarget;
        private float stateTimer = 0f;

        public void Initialize(string name, List<Transform> wander)
        {
            colonistName = name;
            wanderPoints = wander;

            // Setup components
            agent = GetComponent<NavMeshAgent>();
            if (!agent) agent = gameObject.AddComponent<NavMeshAgent>();

            agent.speed = moveSpeed;
            agent.angularSpeed = rotationSpeed;
            agent.stoppingDistance = 0.5f;

            animator = GetComponent<Animator>();

            // Start behavior
            ChangeState(ColonistState.Idle);
        }

        void Update()
        {
            stateTimer += Time.deltaTime;

            switch (currentState)
            {
                case ColonistState.Idle:
                    UpdateIdle();
                    break;
                case ColonistState.Wandering:
                    UpdateWandering();
                    break;
                case ColonistState.WorkingAnimation:
                    UpdateWorking();
                    break;
            }

            // Update animator
            if (animator && agent)
            {
                animator.SetFloat("Speed", agent.velocity.magnitude);
            }
        }

        void UpdateIdle()
        {
            // Wait 2-5 seconds then wander
            if (stateTimer > Random.Range(2f, 5f))
            {
                ChangeState(ColonistState.Wandering);
            }
        }

        void UpdateWandering()
        {
            if (!agent) return;

            // Check if reached destination
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                // Chance to "work" at this location
                if (Random.value < 0.3f && IsNearBuilding())
                {
                    ChangeState(ColonistState.WorkingAnimation);
                }
                else
                {
                    ChangeState(ColonistState.Idle);
                }
            }
        }

        void UpdateWorking()
        {
            // Play work animation for 3-6 seconds
            if (stateTimer > Random.Range(3f, 6f))
            {
                ChangeState(ColonistState.Idle);
            }
        }

        void ChangeState(ColonistState newState)
        {
            currentState = newState;
            stateTimer = 0f;

            switch (newState)
            {
                case ColonistState.Idle:
                    if (agent) agent.isStopped = true;
                    if (animator) animator.SetBool("Working", false);
                    break;

                case ColonistState.Wandering:
                    if (agent) agent.isStopped = false;
                    SelectRandomDestination();
                    if (animator) animator.SetBool("Working", false);
                    break;

                case ColonistState.WorkingAnimation:
                    if (agent) agent.isStopped = true;
                    if (animator) animator.SetBool("Working", true);
                    break;
            }
        }

        void SelectRandomDestination()
        {
            if (wanderPoints == null || wanderPoints.Count == 0 || !agent) return;

            // Pick random wander point
            Transform target = wanderPoints[Random.Range(0, wanderPoints.Count)];

            // Or sometimes go to a building
            if (Random.value < 0.4f)
            {
                Building[] buildings = FindObjectsOfType<Building>();
                if (buildings.Length > 0)
                {
                    Building randomBuilding = buildings[Random.Range(0, buildings.Length)];
                    target = randomBuilding.transform;
                }
            }

            currentTarget = target;
            agent.SetDestination(target.position);
        }

        bool IsNearBuilding()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, 3f);
            foreach (var col in colliders)
            {
                if (col.GetComponent<Building>())
                    return true;
            }
            return false;
        }
    }
}
