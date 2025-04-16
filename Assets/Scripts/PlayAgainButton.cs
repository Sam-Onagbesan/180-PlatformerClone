using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour
{
    public Button PlayAgainButton;
    public GameObject GamePlayScreen;
    public GameObject GameOverScreen;
    public GameObject Player;

    void Start(){
        //listens for button to be clicked
        PlayAgainButton.onClick.AddListener(Clicked);
    }
 
    void Clicked(){
        // sets gamePlay gameobject to active, tells playerController script to set lives to 3 and deactiates the menu 
        GamePlayScreen.SetActive(true);
        Player.GetComponent<PlayerController>().Lives = 3;
        Player.GetComponent<PlayerController>().Health = 100;
        GameOverScreen.SetActive(false);
    }
}
