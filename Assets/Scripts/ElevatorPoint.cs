using UnityEngine;
using UnityEngine.AI;

public class ElevatorPoint : MonoBehaviour
{
    private Elevator _elevator;
    public bool canMove;
    private void Start()
    {
        _elevator = GetComponentInParent<Elevator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!canMove) return;
        _elevator.Move(this, other.GetComponent<NavMeshAgent>());
    }

    private void OnTriggerExit(Collider other)
    {
        canMove = true;
    }
}
