using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitController : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;
    [SerializeField] private Scores scoresScript;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            panelLose.SetActive(true);
            int lastRunScores = int.Parse(scoresScript.scoreText.text.ToString());
            PlayerPrefs.SetInt("lastRunScores", lastRunScores);
            Time.timeScale = 0;
        }
    }
}