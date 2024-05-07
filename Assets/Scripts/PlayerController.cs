using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 2.0f;
    private NavMeshAgent _agent;
    private Camera _mainCamera;

    private void Start()
    {
        _agent = gameObject.GetComponent<NavMeshAgent>();
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        var horizontalAxis = Input.GetAxis("Horizontal");
        var verticalAxis = Input.GetAxis("Vertical");

        var forward = _mainCamera.transform.forward;
        var right = _mainCamera.transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        var move = forward * verticalAxis + right * horizontalAxis;
        _agent.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero) gameObject.transform.forward = move;
    }
}