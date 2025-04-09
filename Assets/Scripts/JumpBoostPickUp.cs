using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostPickUp : MonoBehaviour
{
    void Update(){
        transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<TempPlayerController>().HasJumpBoost = true;
            gameObject.SetActive(false);
        }
    }
}
