using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string HighscorePlayerName;
    public int HighscoreScore;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighscore();
    }

    public void LoadHighscore()
    {
        HighscorePlayerName = PlayerPrefs.GetString("HighscoreName");
        HighscoreScore = PlayerPrefs.GetInt("Highscore");
    }

    public void SaveHighscore()
    {
        Debug.Log("Saved Player Score to Playerprefs");
        PlayerPrefs.SetString("HighscoreName", HighscorePlayerName);
        PlayerPrefs.SetInt("Highscore", HighscoreScore);
    }

    private void OnApplicationQuit()
    {
        SaveHighscore();
    }

}
