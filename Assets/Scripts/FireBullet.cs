using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject regularBullet;
    public GameObject heavyBullet;
    public float timer;
    public bool canShoot = true;
    bool HasHeavyBullet;

    void Update()
    {
       HasHeavyBullet = gameObject.GetComponent<TempPlayerController>().HasHeavyBullet;
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
