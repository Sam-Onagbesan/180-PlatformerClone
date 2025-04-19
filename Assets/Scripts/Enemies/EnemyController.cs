using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// Samuel Onagbesan
/// Controls Enemy Movement
/// 4/19/25
public class EnemyController : MonoBehaviour
{
    public float speed = 5;
    public Vector3 direction;
    private Rigidbody body;

    public int health;
    public int damage = 20;

    public Transform leftPoint;
    public Transform rightPoint;

    public GameObject LeftEye;
    public GameObject RightEye;

    public bool canDamage;


    public Vector3 startPoint;
    public Vector3 endPoint;
    // Start is called before the first frame update
    void Start()
    {
        canDamage = true;
        RightEye.SetActive(false);
        direction = Vector3.right;
        body = GetComponent<Rigidbody>();

        startPoint = leftPoint.position;
        endPoint = rightPoint.position;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        if (health <= 0)
        {
            Death();
        }
    }

    public void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (transform.position.x > endPoint.x)
        {
            RightEye.SetActive(true);
            LeftEye.SetActive(false);
            direction = Vector3.left;
        }
        if (transform.position.x < startPoint.x)
        {

            RightEye.SetActive(false);
            LeftEye.SetActive(true);
            direction = Vector3.right;
        }



    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<PlayerController>() && canDamage)
        {
            collision.gameObject.GetComponent<PlayerController>().Health -= damage;
            print(collision.gameObject.GetComponent<PlayerController>().Health);
            StartCoroutine(WaitToDamage());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RegularBulletController>())
        {
            health -= other.gameObject.GetComponent<RegularBulletController>().damage;
            print(health);
            Destroy(other.gameObject);
        }
        
    }
    private void Death()
    {
        Destroy(gameObject);
    }
   public IEnumerator WaitToDamage()
    {
        canDamage = false;
            yield return new WaitForSeconds(1);
        canDamage = true;
    }
}

