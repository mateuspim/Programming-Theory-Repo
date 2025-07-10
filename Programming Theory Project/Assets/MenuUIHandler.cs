using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
