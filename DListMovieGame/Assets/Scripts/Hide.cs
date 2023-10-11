using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player") print("spooky?");
    }
}
