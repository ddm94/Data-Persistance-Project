using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField inputName;

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ScoreboardScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void StartNew()
    {
        SetPlayerName();

        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        GameManager.Instance.SaveScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    void SetPlayerName()
    {
        if (inputName.text == string.Empty)
            GameManager.Instance.playerName = "AAA";
        else
            GameManager.Instance.playerName = inputName.text;
    }
}
