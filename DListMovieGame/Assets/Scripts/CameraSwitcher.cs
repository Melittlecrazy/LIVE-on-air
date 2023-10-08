using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraSwitcher : MonoBehaviour
{
    public string george;

    public GameObject firstP, thirdP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        //SceneManager.LoadScene(george);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") firstP.SetActive(false); thirdP.SetActive(true); 
    }
}
