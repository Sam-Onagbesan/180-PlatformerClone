using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
Piper Johnson
4/20/2025

when playe button is clicked loads mainlevel and unloads Menuscene
*/


public class PlayAgainButton : MonoBehaviour
{
    public Button PlayButton;

    void Start(){
        //listens for button to be clicked
        PlayButton.onClick.AddListener(Clicked);
    }
 
    void Clicked(){
        // loads MainLevel scene and unloads menuScene
        SceneManager.LoadScene("MainLevel");
        SceneManager.UnloadScene("MenuScene");
    }
}
