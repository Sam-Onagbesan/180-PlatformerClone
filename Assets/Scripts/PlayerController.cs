using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// Samuel Onagbesan
/// Controls Player Movement
///
public class PlayerController : MonoBehaviour

{
    public float speed = 10;
    public float jumpForce = 1;
    public int coins = 0;
    private Rigidbody rigidBody;
    public int MaxHealth = 100;
    public int Health;
    public int Lives = 3;
    public GameObject Spawner;
    public bool facingRight;

    public bool HasJumpBoost = false;
    public float jumpForceMultiplyer = 1f;
    public float jumpTimer;
    public bool HasHeavyBullet;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Spawner.transform.position;
        rigidBody = GetComponent<Rigidbody>();
        Health = MaxHealth;
        facingRight = true;
       
    }

    private void FixedUpdate()
    {
        if(HasJumpBoost){
            JumpBoost();
        }
        if(transform.position.y <= -10){
            LoseLife();
        }

        if(Health <= 0)
        {
            LoseLife();
        }
        PlayerMove();
        Jump();
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
    }


    //Check for input to move player left or right
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            facingRight = true;
            transform.position += Vector3.right * speed * Time.deltaTime;
            // rigidBody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            facingRight = false;
            transform.position += Vector3.left * speed * Time.deltaTime;
            // rigidBody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        


    }
    private void Jump()
    {

        if (Input.GetKey(KeyCode.Space) && OnGround())
        {
            rigidBody.AddForce(Vector3.up * (jumpForce * jumpForceMultiplyer), ForceMode.Impulse);

        }

    }
    private bool OnGround()
    {
        bool OnGround = false;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.3f))
        {
            OnGround = true;
        }

        return OnGround;


    }
    public void LoseLife()
    {
        Lives--;
        Health = 100;
        transform.position = Spawner.transform.position;
    }

    void JumpBoost(){
        jumpForceMultiplyer = 3f;
        if(jumpTimer > 0){
            jumpTimer -= Time.deltaTime;
        }else{
            HasJumpBoost = false;
            jumpForceMultiplyer = 1f;
        }
    }
    private void Update()
    {
        print(Health);
        if (Health <= 0)
        {
            LoseLife();
        }
    }
}
