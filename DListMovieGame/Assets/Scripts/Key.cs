using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    bool hasKey;
    public GameObject key, hand, door;


    public string george;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            key.transform.parent = hand.transform.parent;
            key.transform.position = hand.transform.position;
            key.transform.rotation = hand.transform.rotation;
            hasKey = true; 
        }


        if (hasKey == true) 
        { 
             
            door.SetActive(false); 
        }
    }

}
