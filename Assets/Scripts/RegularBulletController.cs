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
    public Vector3 PlayerDir;
    public float speed = 5f;
    public int damage = 10;


    void Start()
    {
        // sets rotation to be 90 degrees
        gameObject.transform.rotation = Quaternion.Euler(0,0,90f);
        //finds Player (needs to be changed once we make reall player)
        Player = GameObject.Find("Player");
        // gets bullet direction by checking if player is facing right
        bool facingRight = Player.GetComponent<PlayerController>().facingRight;
        
        // if player is facing right sets bullets to move right 
        // if player facing left sets bullets to move left
        if(facingRight){
            bulletDir = Vector3.right;
        }else if (!facingRight){
            bulletDir = Vector3.left;
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
        Destroy(gameObject);

    }
     

}
