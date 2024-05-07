using UnityEngine;
using UnityEngine.AI;

public class Elevator : MonoBehaviour
{
    [SerializeField] private Transform destination;

    private void OnTriggerEnter(Collider other)
    {
        var agent = other.GetComponent<NavMeshAgent>();
        if (agent != null)
            agent.Warp(destination.position);
    }
}
