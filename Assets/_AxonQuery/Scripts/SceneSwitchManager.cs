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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SwitchScene();
            }
        }

        public void SwitchScene()
        {
            SceneManager.UnloadSceneAsync(currentSceneIndex);
            currentSceneIndex += 1;
          
            if (currentSceneIndex == SceneManager.sceneCountInBuildSettings)
            {
#if UNITY_EDITOR                
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
            }

            SceneManager.LoadSceneAsync(currentSceneIndex, LoadSceneMode.Additive);
        
        }
    }
}