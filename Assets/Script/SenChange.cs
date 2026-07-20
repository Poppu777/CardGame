using UnityEngine;
using UnityEngine.SceneManagement;

public class SenChange : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    public void LoadScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogWarning("Scene Name is not set.");
            return;
        }

        SceneManager.LoadScene(sceneName);
    }
}
