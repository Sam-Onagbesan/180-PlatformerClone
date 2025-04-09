using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKits : MonoBehaviour
{
    public int AmountOfHealth;

    void Update(){
        transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<TempPlayerController>().playerHealth += AmountOfHealth;
            gameObject.SetActive(false);
        }
    }
}
