using UnityEngine;
using UnityEngine.Serialization;

namespace _AxonQuery.Scripts
{
    public class ObscureObject : MonoBehaviour
    {
        [HideInInspector] [SerializeField] private Renderer[] renderers;

        private void Start()
        {
            foreach (var rend in renderers) rend.material.renderQueue = 2002;
        }

        private void OnValidate()
        {
            renderers = GetComponentsInChildren<Renderer>();
        }
    }
}