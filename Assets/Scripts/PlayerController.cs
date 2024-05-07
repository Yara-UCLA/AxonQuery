using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] private float playerSpeed = 2.0f;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        var camera = Camera.main;
        var forward = camera.transform.forward;
        var right = camera.transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();


        Vector3 move = forward * verticalAxis + right * horizontalAxis;
        agent.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}