using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPlayerController : MonoBehaviour
{
    float speed = 8f;
    Vector3 dir;
    float jumpForce = 8f;
    private Rigidbody playerRigidbody;


    void Start(){
        // gets players rigidbody and saves start position as respawn point
        playerRigidbody = GetComponent<Rigidbody>();
       
    }

    void Update()
    {


            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
                // sets direction to left and runs move function
                dir = Vector3.left;
                Move(dir);
            }
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
                //set direction to right and runs move function
                dir = Vector3.right;
                Move(dir);
            }
            if ((Input.GetKeyDown("w") || Input.GetKeyDown("space") ||  Input.GetKeyDown(KeyCode.UpArrow)) && OnGround()){
                //sets direction to up and runs jump function
                dir = Vector3.up;
                Jump(dir);
            }
    }

    void Move(Vector3 dir){
        // move player in given direction
        transform.position += dir * speed * Time.deltaTime;
    }

    void Jump(Vector3 dir){
        // uses rigidbody to make player jump up
            playerRigidbody.AddForce(dir * jumpForce, ForceMode.Impulse);
    }

    bool OnGround(){
        // uses raycast to check if the plqyer is within 0.6 units of the ground 
        // if so retuns true else returns false
        bool onGround = false;
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 0.6f)){
            onGround = true;
        }
        return onGround;
    }

}

