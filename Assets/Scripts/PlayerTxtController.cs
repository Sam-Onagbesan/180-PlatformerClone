using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;


public class PlayerTxtController : MonoBehaviour
{
    public TMP_Text t;
    public GameObject Player;
    int health;
    int lives;
    public GameObject GameOverScreen;
    public GameObject GamePlayScreen;

    // Update is called once per frame
    void Update()
    {
        health = Player.GetComponent<PlayerController>().Health;
        lives = Player.GetComponent<PlayerController>().Lives;
        t.text = "Health: " + health.ToString() + Environment.NewLine + "Lives: " + lives.ToString();
        CheckGameOver();
    }
    
    void CheckGameOver(){
        if (lives <= 0){
            GameOverScreen.SetActive(true);
            GamePlayScreen.SetActive(false);
        }
    }
}
