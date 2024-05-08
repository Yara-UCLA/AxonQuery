using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SceneSwitchManager : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex;
    private void Start()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1, LoadSceneMode.Additive);
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