using UnityEngine;

namespace _AxonQuery.Scripts
{
    public class SceneSwitchTrigger : MonoBehaviour
    {
        private SceneSwitchManager _sceneSwitchManager;

        private void Start()
        {
            _sceneSwitchManager = GameObject.FindWithTag("SceneManager").GetComponent<SceneSwitchManager>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _sceneSwitchManager.SwitchScene();
        }
    }
}