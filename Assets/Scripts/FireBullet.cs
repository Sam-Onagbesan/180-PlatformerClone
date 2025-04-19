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
    public bool canShoot;
    public bool HasHeavyBullet;
    public Vector3 dirFacing;
    // public Vector3 shootAhead = new Vector3(1, 0, 0);
    // public Vector3 shootBack = new Vector3(1, 0, 0);


    void Update()

    {

      // if k is pressed instanct object 
      if ((Input.GetKey("k")) && canShoot){
        if(HasHeavyBullet){
                print("fired Heavy");
                Instantiate(heavyBullet, transform.position + new Vector3(1f,0,0), Quaternion.identity);
            }

        }
        
                if(dirFacing == Vector3.forward)
                {
                    Instantiate(regularBullet, transform.position + new Vector3(1f, 0, 0), Quaternion.identity);
                print("fired Regular");
                }
                else
                {
                    Instantiate(regularBullet, transform.position + new Vector3(1f, 0, 0), Quaternion.identity);
                print("fired Regular");
                }
                    
    
            timer = 0.15f;
            canShoot = false;
        


        if (timer >= 0f){
            timer -= Time.deltaTime;
        }else{
            canShoot = true;
        }
    }
}

