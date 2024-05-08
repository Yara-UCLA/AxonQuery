using UnityEngine;
using UnityEngine.SceneManagement;

namespace _AxonQuery.Scripts
{
    public class SceneSwitchManager : MonoBehaviour
    {
        [SerializeField] private int currentSceneIndex;

        private void Start()
        {
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            currentSceneIndex = 1;
        }

        public void SwitchScene()
        {
            SceneManager.UnloadSceneAsync(currentSceneIndex);
            currentSceneIndex += 1;

            if (currentSceneIndex == SceneManager.sceneCountInBuildSettings)
            {
                currentSceneIndex = 0;
                return;
            }

            SceneManager.LoadScene(currentSceneIndex, LoadSceneMode.Additive);
        }
    }
}