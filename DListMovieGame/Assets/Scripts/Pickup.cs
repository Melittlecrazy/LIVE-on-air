using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject bat,hand;
    public Collider grab;


    private void Start()
    {
        bat.transform.parent = null;
        //body2.transform.parent = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bat.transform.parent = hand.transform.parent;
            bat.transform.position = hand.transform.position;
            bat.transform.rotation = hand.transform.rotation;
        }
    }
}
