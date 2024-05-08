using UnityEngine;
using UnityEngine.AI;

namespace _AxonQuery.Scripts
{
    public class Elevator : MonoBehaviour
    {
        [HideInInspector] [SerializeField] private ElevatorPoint high;
        [HideInInspector] [SerializeField] private ElevatorPoint low;

        public void OnValidate()
        {
            var elevatorPoints = GetComponentsInChildren<ElevatorPoint>();
            low = elevatorPoints[0];
            high = elevatorPoints[1];
        }

        public void Move(ElevatorPoint current, Collider col)
        {
            var agent = col.GetComponent<NavMeshAgent>();
            if (current == low)
            {
                agent.Warp(high.transform.position);
                high.canMove = false;
            }

            else
            {
                agent.Warp(low.transform.position);
                low.canMove = false;
            }
        }
    }
}