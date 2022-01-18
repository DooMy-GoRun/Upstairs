using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public Text scoreText;
   
    void Update()
    {
        scoreText.text = ((int)(player.position.z + player.position.y)/2).ToString();
    }
}
