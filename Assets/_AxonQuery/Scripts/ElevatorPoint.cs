using UnityEngine;

namespace _AxonQuery.Scripts
{
    public class ElevatorPoint : MonoBehaviour
    {
        [HideInInspector] [SerializeField] private Elevator elevator;
        [HideInInspector] public bool canMove = true;

        private void OnTriggerEnter(Collider other)
        {
            if (!canMove) return;
            elevator.Move(this, other);
        }

        private void OnTriggerExit(Collider other)
        {
            canMove = true;
        }

        private void OnValidate()
        {
            elevator = GetComponentInParent<Elevator>();
        }
    }
}