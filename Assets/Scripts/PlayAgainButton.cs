using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayAgainButton : MonoBehaviour
{
    public Button PlayButton;
    public GameObject GamePlayScreen;
    public GameObject GameOverScreen;
    public GameObject Player;

    void Start(){
        //listens for button to be clicked
        PlayButton.onClick.AddListener(Clicked);
    }
 
    void Clicked(){
        // sets gamePlay gameobject to active, tells playerController script to set lives to 3 and deactiates the menu 
        GamePlayScreen.SetActive(true);
        Player.GetComponent<PlayerController>().Lives = 3;
        Player.GetComponent<PlayerController>().Health = 100;
        GameOverScreen.SetActive(false);
    }
}
