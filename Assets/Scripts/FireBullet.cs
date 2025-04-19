using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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
    public Vector3 shootAhead = new Vector3(1, 0, 0);
    public Vector3 shootBack = new Vector3(1, 0, 0);


    void Update()

    {

        HasHeavyBullet = gameObject.GetComponent<PlayerController>().HasHeavyBullet;
        // if k is pressed instanct object 
        if ((Input.GetKey("k")) && canShoot)
        {
            if (HasHeavyBullet)
            {

                if (dirFacing == Vector3.forward)
                {
                    Instantiate(heavyBullet, transform.position + transform.right, Quaternion.identity);
                    print("fired Heavy");
                    StartCoroutine(WaitToShoot());
                }
                else
                {
                    Instantiate(heavyBullet, transform.position + transform.right, Quaternion.identity);
                    print("fired Heavy");
                    StartCoroutine(WaitToShoot());
                }

            }


            else
            if (dirFacing == Vector3.forward)
            {
                Instantiate(regularBullet, transform.position + transform.right, Quaternion.identity);
                print("fired Regular");
                StartCoroutine(WaitToShoot());
            }
            else
            {
                Instantiate(regularBullet, transform.position + transform.right, Quaternion.identity);
                print("fired Regular");
                StartCoroutine(WaitToShoot());
            }
            
           



           
            

        }
       
    }
    public IEnumerator WaitToShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.5f);
        canShoot = true;
    }
}


   
          
        
    


