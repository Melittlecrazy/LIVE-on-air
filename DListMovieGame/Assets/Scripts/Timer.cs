using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float StunTimer;
    public float hit;
    public GameObject wall;


    private void Update()
    {
        
            if (StunTimer > 0)
                {
                    StunTimer -= Time.deltaTime;
                    return;  // you are stunned, sit still!
                }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Respawn")
        {
            //StunTimer += hit;

            wall.SetActive(false);

            print("OH YEAAAA!");

        }
    }
}
