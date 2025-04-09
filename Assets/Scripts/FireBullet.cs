using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject regularBullet;

    void Update()
    {
      // if k is pressed instanct object 
      if (Input.GetKey("k")){
            Instantiate(regularBullet, transform.position, transform.rotation);
        }  
    }
}
