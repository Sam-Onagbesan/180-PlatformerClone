using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePortal : MonoBehaviour
{
    // public GameObject GameOverScreen;
    // public GameObject GamePlayScreen;

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            SceneManager.LoadScene("MenuScene");
            SceneManager.UnloadSceneAsync("MainLevel");
        }
     }
}
