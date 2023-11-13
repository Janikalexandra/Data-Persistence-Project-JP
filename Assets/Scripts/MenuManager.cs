using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{

    public TMP_Text PlayerNameHighscoreText;
    public TMP_Text HighscoreText;


    private void Start()
    {
        if(PlayerNameHighscoreText)
        PlayerNameHighscoreText.text = "Highscore: " + DataManager.Instance.HighscorePlayerName + ": " + DataManager.Instance.HighscoreScore;
    }
    

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
