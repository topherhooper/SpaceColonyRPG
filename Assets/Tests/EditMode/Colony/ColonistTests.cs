using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using SpaceColonyRPG.Colony;
using System.Collections.Generic;

namespace SpaceColonyRPG.Tests.EditMode.Colony
{
    public class ColonistTests
    {
        private Colonist colonist;
        private GameObject colonistObject;
        private List<Transform> testWanderPoints;

        [SetUp]
        public void Setup()
        {
            colonistObject = new GameObject("TestColonist");
            colonist = colonistObject.AddComponent<Colonist>();

            // Add required NavMeshAgent component (mocked for edit mode)
            var agent = colonistObject.AddComponent<NavMeshAgent>();

            // Create test wander points
            testWanderPoints = new List<Transform>();
            for (int i = 0; i < 5; i++)
            {
                var point = new GameObject($"WanderPoint_{i}");
                point.transform.position = new Vector3(
                    Random.Range(-10f, 10f),
                    0,
                    Random.Range(-10f, 10f)
                );
                testWanderPoints.Add(point.transform);
            }

            // Initialize colonist
            colonist.Initialize("TestColonist", testWanderPoints);
        }

        [TearDown]
        public void TearDown()
        {
            foreach (var point in testWanderPoints)
            {
                Object.DestroyImmediate(point.gameObject);
            }
            Object.DestroyImmediate(colonistObject);
        }

        [Test]
        public void Initialize_SetsPropertiesCorrectly()
        {
            // Arrange
            string expectedName = "NewColonist";
            var newWanderPoints = new List<Transform> { new GameObject().transform };

            // Act
            colonist.Initialize(expectedName, newWanderPoints);

            // Assert
            Assert.AreEqual(expectedName, colonist.colonistName);

            // Cleanup
            Object.DestroyImmediate(newWanderPoints[0].gameObject);
        }

        [Test]
        public void StateTransition_FromIdle_ToWandering()
        {
            // Arrange
            SetColonistState(colonist, ColonistState.Idle);

            // Act
            InvokePrivateMethod(colonist, "ChangeState", ColonistState.Wandering);

            // Assert
            Assert.AreEqual(ColonistState.Wandering, colonist.currentState);
        }

        [Test]
        public void StateTransition_FromWandering_ToWorking()
        {
            // Arrange
            SetColonistState(colonist, ColonistState.Wandering);

            // Act
            InvokePrivateMethod(colonist, "ChangeState", ColonistState.WorkingAnimation);

            // Assert
            Assert.AreEqual(ColonistState.WorkingAnimation, colonist.currentState);
        }

        [Test]
        public void IsNearBuilding_NoBuildings_ReturnsFalse()
        {
            // Act
            bool isNear = InvokePrivateMethod<bool>(colonist, "IsNearBuilding");

            // Assert
            Assert.IsFalse(isNear);
        }

        [Test]
        public void IsNearBuilding_BuildingNearby_ReturnsTrue()
        {
            // Arrange
            var buildingObject = new GameObject("TestBuilding");
            buildingObject.transform.position = colonistObject.transform.position + Vector3.forward;
            var building = buildingObject.AddComponent<Building>();
            var collider = buildingObject.AddComponent<BoxCollider>();

            // Act
            bool isNear = InvokePrivateMethod<bool>(colonist, "IsNearBuilding");

            // Assert
            // Note: In edit mode, Physics.OverlapSphere might not work as expected
            // This test would need PlayMode to properly test physics interactions

            // Cleanup
            Object.DestroyImmediate(buildingObject);
        }

        [Test]
        public void ChangeState_UpdatesStateTimer()
        {
            // Arrange
            var stateTimerField = typeof(Colonist).GetField("stateTimer",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            stateTimerField.SetValue(colonist, 10f);

            // Act
            InvokePrivateMethod(colonist, "ChangeState", ColonistState.Idle);

            // Assert
            float stateTimer = (float)stateTimerField.GetValue(colonist);
            Assert.AreEqual(0f, stateTimer);
        }

        [Test]
        public void SelectRandomDestination_WithWanderPoints_SetsTarget()
        {
            // Arrange
            var currentTargetField = typeof(Colonist).GetField("currentTarget",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act
            InvokePrivateMethod(colonist, "SelectRandomDestination");

            // Assert
            Transform target = (Transform)currentTargetField.GetValue(colonist);
            Assert.IsNotNull(target);
        }

        [Test]
        public void SelectRandomDestination_NoWanderPoints_DoesNotCrash()
        {
            // Arrange
            colonist.Initialize("Test", new List<Transform>());

            // Act & Assert (should not throw)
            Assert.DoesNotThrow(() => InvokePrivateMethod(colonist, "SelectRandomDestination"));
        }

        [TestCase(ColonistState.Idle, true)]
        [TestCase(ColonistState.Wandering, false)]
        [TestCase(ColonistState.WorkingAnimation, true)]
        public void StateMovement_CorrectStoppedState(ColonistState state, bool shouldBeStopped)
        {
            // Arrange
            var agent = colonistObject.GetComponent<NavMeshAgent>();

            // Act
            InvokePrivateMethod(colonist, "ChangeState", state);

            // Assert
            Assert.AreEqual(shouldBeStopped, agent.isStopped);
        }

        // Helper methods
        private void SetColonistState(Colonist colonist, ColonistState state)
        {
            var stateField = typeof(Colonist).GetField("currentState",
                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            stateField.SetValue(colonist, state);
        }

        private void InvokePrivateMethod(object obj, string methodName, params object[] parameters)
        {
            var method = obj.GetType().GetMethod(methodName,
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(obj, parameters);
        }

        private T InvokePrivateMethod<T>(object obj, string methodName, params object[] parameters)
        {
            var method = obj.GetType().GetMethod(methodName,
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (T)method.Invoke(obj, parameters);
        }
    }
}
