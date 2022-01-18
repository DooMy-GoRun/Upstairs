using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private Text recordText;

    void Start()
    {
        Time.timeScale = 1;

        int lastRunScores = PlayerPrefs.GetInt("lastRunScores");
        int recordScores = PlayerPrefs.GetInt("recordScores");

        if(lastRunScores > recordScores)
        {
            recordScores = lastRunScores;
            PlayerPrefs.SetInt("recordScores", recordScores);
            recordText.text = recordScores.ToString();
        }
        else
        {
            recordText.text = recordScores.ToString();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
