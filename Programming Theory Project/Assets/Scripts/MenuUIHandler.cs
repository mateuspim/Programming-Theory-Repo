using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor.ShaderGraph;

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
        GameManager.Instance.PlayerName = value.ToUpper();
        if (!string.IsNullOrEmpty(value))
            playerNameInputField.GetComponent<Image>().color = Color.white;
    }

    public void StartGame()
    {
        if (!string.IsNullOrEmpty(GameManager.Instance.PlayerName))
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            playerNameInputField.GetComponent<Image>().color = Color.red;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
