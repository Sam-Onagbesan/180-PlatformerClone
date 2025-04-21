using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
/*
Piper Johnson
4/20/2025

displays players health and lives in the top right corner 
also checks if game is over
*/

public class PlayerTxtController : MonoBehaviour
{
    public TMP_Text t;
    public GameObject Player;
    int health;
    int lives;

    void Update()
    {
        // gets player health and lives
        health = Player.GetComponent<PlayerController>().Health;
        lives = Player.GetComponent<PlayerController>().Lives;
        // displays health and lives on screen 
        t.text = "Health: " + health.ToString() + Environment.NewLine + "Lives: " + lives.ToString();
        //runs function to check if game is over
        CheckGameOver();
    }
    
    void CheckGameOver(){
        if (lives <= 0){
            // loads menuScene and unloads MainLevel scene 
            SceneManager.LoadScene("MenuScene");
            SceneManager.UnloadScene("MainLevel");
        }
    }
}
