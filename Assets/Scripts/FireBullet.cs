using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject regularBullet;
    public float timer;
    public bool canShoot = true;

    void Update()
    {
      // if k is pressed instanct object 
      if ((Input.GetKey("k")) && canShoot){
            Instantiate(regularBullet, transform.position, transform.rotation);
            timer = 0.3f;
            canShoot = false;
        }  

        if (timer >= 0f){
            timer -= Time.deltaTime;
        }else{
            canShoot = true;
        }
    }
}
