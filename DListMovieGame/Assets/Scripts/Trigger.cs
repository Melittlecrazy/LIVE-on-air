using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject on,off;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") on.SetActive(true); off.SetActive(false);
    }
}
