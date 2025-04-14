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

    // Update is called once per frame
    void Update()
    {
        health = Player.GetComponent<TempPlayerController>().playerHealth;
        t.text = "Health: " + health.ToString();
    }
}
