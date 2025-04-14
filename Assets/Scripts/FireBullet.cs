using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/7/2025

if k is pressed it fires bullet can fire every 0.15 seconds
if player has heavyBullet player will fire else it will fire normal bullets
each time fired it restarts the timer for 15 secconds and canot fire until timer is complete

*/

public class FireBullet : MonoBehaviour
{
    public GameObject regularBullet;
    public GameObject heavyBullet;
    public float timer;
    public bool canShoot = true;
    bool HasHeavyBullet;
    public Vector3 dirFacing;

    void Update()
    {
       HasHeavyBullet = gameObject.GetComponent<PlayerController>().HasHeavyBullet;
      // if k is pressed instanct object 
      if ((Input.GetKey("k")) && canShoot){
        if(HasHeavyBullet){
            Instantiate(heavyBullet, transform.position, transform.rotation);
        }else {
            Instantiate(regularBullet, transform.position, transform.rotation);
        }
            timer = 0.15f;
            canShoot = false;
        }  


        if (timer >= 0f){
            timer -= Time.deltaTime;
        }else{
            canShoot = true;
        }
    }
}
