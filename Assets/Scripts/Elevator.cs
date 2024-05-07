using UnityEngine;
using UnityEngine.AI;

public class Elevator : MonoBehaviour
{
    private Transform _destination;

    private void Start()
    {
        _destination = GetComponentInChildren<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var agent = other.GetComponent<NavMeshAgent>();
        if (agent != null)
            agent.Warp(_destination.position);
    }
}