using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/19/2025

Causes the cube to rotate
when the player hits the object player HasHeavyBullet is true allowing player to shoot the heavy bullets
then object is not setactive 

*/

public class HeavyBulletPickUp : MonoBehaviour
{
    public GameObject Player;

    void Update(){
        //makes objects rotate
        transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }

    void OnTriggerEnter(Collider other){
        // if player hits objects bool HasHeavyBullet from PlayerController Script gets set to true
        if(other.gameObject.tag == "Player"){
            Player.GetComponent<PlayerController>().HasHeavyBullet = true;
            // game object gets destroied
            Destroy(gameObject);
        }
       
    }
    private void Start()
    {
        Player = GameObject.Find("Player");
    }
}
