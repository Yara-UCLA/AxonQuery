using UnityEngine;
using UnityEngine.AI;

public class Elevator : MonoBehaviour
{
    private ElevatorPoint _high;
    private ElevatorPoint _low;

    public void OnValidate()
    {
        var elevatorPoints = GetComponentsInChildren<ElevatorPoint>();
        _low = elevatorPoints[0];
        _high = elevatorPoints[1];
    }

    public void Move(ElevatorPoint current, NavMeshAgent agent)
    {
        if (current == _low)
        {
            agent.Warp(_high.transform.position);
            _high.canMove = false;
        }

        else
        {
            agent.Warp(_low.transform.position);
            _low.canMove = false;
        }
    }
}