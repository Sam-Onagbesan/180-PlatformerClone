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
    public Vector3 bulletDir;
    public float speed = 5f;


    void Start()
    {
        // sets rotation to be 90 degrees
        gameObject.transform.rotation = Quaternion.Euler(0,0,90f);
        //finds Player (needs to be changed once we make reall player)
        Player = GameObject.Find("TempPlayer");
        // gets bullet direction by getting direction player is facing/last went 
        bulletDir = Player.GetComponent<TempPlayerController>().dir;
        if(bulletDir == Vector3.up){
            bulletDir = Vector3.right;
        }
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
        if(other.tag == "Player"){
            return;
        }
        if(other.tag == "Enemy"){
            // on triggers subtract hp from enemy
            // other.gameObject.GetComponent<EnemyScript>().HP -= 5;
        }
        // on trigger hits anything
        // then delete self
        Destroy(gameObject);
    }
     

}
