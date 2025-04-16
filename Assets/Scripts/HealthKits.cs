using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/10/2025

Causes the cube to rotate
when the player hits the object player health is increased by AmountOfHealth
then object is not setactive 

*/

public class HealthKits : MonoBehaviour
{
    public int AmountOfHealth;
    public GameObject Player;

    void Update(){
        transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Player.GetComponent<PlayerController>().Health += AmountOfHealth;
            gameObject.SetActive(false);
        }
    }
}
