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
    public bool HasHeavyBullet = false;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Spawner.transform.position;
        rigidBody = GetComponent<Rigidbody>();
        Health = MaxHealth;
       
    }

    private void FixedUpdate()
    {
        PlayerMove();
        Jump();
    }


    //Check for input to move player left or right
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            facingRight = true;
            //transform.position += Vector3.right * speed * Time.deltaTime;
            rigidBody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            facingRight = false;
            // transform.position += Vector3.left * speed * Time.deltaTime;
            rigidBody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Health <= 0)
        {
            LoseLife();
        }


    }
    private void Jump()
    {

        if (Input.GetKey(KeyCode.Space) && OnGround())
        {
          
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

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
        if (Lives <= 1)
        {
            SceneManager.LoadScene(1);

        }
        else
        {
            Lives--;
            Health = 100;
            transform.position = Spawner.transform.position;
        }
    }
   
}
