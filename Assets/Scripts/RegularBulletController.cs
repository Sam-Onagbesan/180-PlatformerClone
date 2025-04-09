using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Piper Johnson
4/7/2025

controlles the movement of the regularBullet once it is created

*/

public class RegularBulletController : MonoBehaviour
{
    public GameObject Player;
    public Quaternion bulletFacing;
    public Vector3 bulletDir;
    public float speed = 5f;


    void Start()
    {
        Player = GameObject.Find("TempPlayer");

        //get direction of player
        //set bullet to that direction
        bulletFacing = Player.transform.rotation;
        gameObject.transform.rotation = bulletFacing;

        // sets direction to be strait ahead no matter the rotation at time of spawn in
        bulletDir = new Vector3(bulletFacing.z, 0, 0);
    }

    void Update()
    {
        move();
    }

    void move(){
        // move forward/in direction facing 
        transform.position += bulletDir * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Enemy"){
            // on triggers subtract hp from enemy
            // other.gameObject.GetComponent<EnemyScript>().HP -= 5;
        }
        // on trigger hits anything
        // then delete self
        Destroy(gameObject);
    }
     

}
