using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField playerNameInputField;

    void Start()
    {
        playerNameInputField.onValueChanged.AddListener(UpdatePlayerName);
    }

    void UpdatePlayerName(string value)
    {
        GameManager.Instance.PlayerName = value;
    }

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
