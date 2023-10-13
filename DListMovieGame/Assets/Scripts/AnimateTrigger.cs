using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTrigger : MonoBehaviour
{
    public Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") m_Animator.SetTrigger("tree");
    }
}
