using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        { 
            print("spooky?"); 
        }
    }

}
