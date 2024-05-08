using UnityEngine;
using UnityEngine.AI;

public class ElevatorPoint : MonoBehaviour
{
    public bool canMove;
    private Elevator _elevator;

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