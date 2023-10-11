using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CameraSwitcher : MonoBehaviour
{
    public string george;

    bool hasKey = false;

    public GameObject firstP, thirdP, key;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") firstP.SetActive(false); thirdP.SetActive(true);

        //if (other.gameObject.tag == "Key") { hasKey = true; }

        if (other.gameObject.tag == "Player") SceneManager.LoadScene(george);
    }
}
