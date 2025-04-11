using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/10/2025

Causes the cube to rotate
when the player hits the object player health is set to 200 
then object is not setactive 

*/

public class SuperHealthKit : MonoBehaviour
{
    void Update(){
        transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<TempPlayerController>().playerHealth = 200;
            gameObject.SetActive(false);
        }
    }
}
