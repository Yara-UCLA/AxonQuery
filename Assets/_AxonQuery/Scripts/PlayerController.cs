using UnityEngine;
using UnityEngine.AI;

namespace _AxonQuery.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float playerSpeed = 2.0f;
        [HideInInspector] [SerializeField] private NavMeshAgent agent;
        [HideInInspector] [SerializeField] private Camera mainCamera;

        private void Update()
        {
            var horizontalAxis = Input.GetAxis("Horizontal");
            var verticalAxis = Input.GetAxis("Vertical");

            var forward = mainCamera.transform.forward;
            var right = mainCamera.transform.right;

            forward.y = 0f;
            right.y = 0f;
            forward.Normalize();
            right.Normalize();

            var move = forward * verticalAxis + right * horizontalAxis;
            agent.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero) gameObject.transform.forward = move;
        }

        private void OnValidate()
        {
            agent = gameObject.GetComponent<NavMeshAgent>();
            mainCamera = Camera.main;
        }
    }
}