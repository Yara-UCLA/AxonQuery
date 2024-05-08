using System;
using UnityEngine;
using UnityEngine.AI;

public class ElevatorPoint : MonoBehaviour
{
    [HideInInspector] [SerializeField] private Elevator elevator;
    [NonSerialized] public bool CanMove = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!CanMove) return;
        elevator.Move(this, other);
    }

    private void OnTriggerExit(Collider other)
    {
        CanMove = true;
    }

    private void OnValidate()
    {
        elevator = GetComponentInParent<Elevator>();
    }
}