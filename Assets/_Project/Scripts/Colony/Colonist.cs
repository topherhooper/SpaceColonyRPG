using UnityEngine;
using UnityEngine.AI;

public class Colonist : MonoBehaviour
{
    public enum State { Idle, Working, Moving }
    
    [Header("State")]
    public State currentState = State.Idle;
    
    [Header("Movement")]
    public float moveSpeed = 3f;
    public float workSpeed = 1f;
    
    [Header("Work")]
    private Building targetBuilding;
    private Vector3 targetPosition;
    private float idleTimer = 0f;
    private float searchInterval = 2f;
    
    private NavMeshAgent navAgent;
    
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        if (navAgent != null)
        {
            navAgent.speed = moveSpeed;
        }
        
        idleTimer = Random.Range(0f, searchInterval);
    }
    
    void Update()
    {
        switch (currentState)
        {
            case State.Idle:
                HandleIdle();
                break;
                
            case State.Moving:
                HandleMoving();
                break;
                
            case State.Working:
                HandleWorking();
                break;
        }
    }
    
    void HandleIdle()
    {
        idleTimer += Time.deltaTime;
        
        if (idleTimer >= searchInterval)
        {
            idleTimer = 0f;
            FindNearestJob();
        }
    }
    
    void HandleMoving()
    {
        if (navAgent != null && navAgent.enabled)
        {
            if (!navAgent.pathPending && navAgent.remainingDistance < 0.5f)
            {
                if (targetBuilding != null)
                {
                    currentState = State.Working;
                    targetBuilding.SetWorker(true);
                }
                else
                {
                    currentState = State.Idle;
                }
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, targetPosition) < 0.5f)
            {
                if (targetBuilding != null)
                {
                    currentState = State.Working;
                    targetBuilding.SetWorker(true);
                }
                else
                {
                    currentState = State.Idle;
                }
            }
        }
    }
    
    void HandleWorking()
    {
        if (targetBuilding == null || !targetBuilding.NeedsWork())
        {
            if (targetBuilding != null)
            {
                targetBuilding.SetWorker(false);
            }
            
            targetBuilding = null;
            currentState = State.Idle;
            return;
        }
        
        targetBuilding.AddWork(workSpeed * Time.deltaTime);
        
        Vector3 lookDirection = (targetBuilding.transform.position - transform.position).normalized;
        if (lookDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), Time.deltaTime * 5f);
        }
    }
    
    void FindNearestJob()
    {
        Building[] buildings = FindObjectsOfType<Building>();
        Building nearestBuilding = null;
        float nearestDistance = float.MaxValue;
        
        foreach (Building building in buildings)
        {
            if (building.NeedsWork())
            {
                float distance = Vector3.Distance(transform.position, building.transform.position);
                if (distance < nearestDistance)
                {
                    nearestBuilding = building;
                    nearestDistance = distance;
                }
            }
        }
        
        if (nearestBuilding != null)
        {
            targetBuilding = nearestBuilding;
            targetPosition = nearestBuilding.workPosition != null ? 
                           nearestBuilding.workPosition.position : 
                           nearestBuilding.transform.position;
            
            currentState = State.Moving;
            
            if (navAgent != null && navAgent.enabled)
            {
                navAgent.SetDestination(targetPosition);
            }
        }
    }
    
    void OnDestroy()
    {
        if (targetBuilding != null)
        {
            targetBuilding.SetWorker(false);
        }
    }
    
    void OnDrawGizmosSelected()
    {
        if (targetBuilding != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, targetBuilding.transform.position);
        }
    }
}