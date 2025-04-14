using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/14/2025
if player collides with portal player gets teleported to where ever the teleportPoint is 

*/

public class PortalController : MonoBehaviour
{
   public Transform teleportPoint;

     void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            // if collided by player teleports to gameobject TeleportPoints' location
            collision.gameObject.transform.position = teleportPoint.transform.position;
        }
     }
}
