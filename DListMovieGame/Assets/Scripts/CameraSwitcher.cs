using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CameraSwitcher : MonoBehaviour
{
    public string george;

    public bool hasKey;

    public GameObject firstP, thirdP, key, smile, frown, door1,door2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") firstP.SetActive(false); thirdP.SetActive(true); frown.SetActive(false); smile.SetActive(true); door1.SetActive(false); door2.SetActive(true);

        //if (other.gameObject.tag == "Key") { hasKey = true; }

        if (other.gameObject.tag == "Player" && hasKey == true) SceneManager.LoadScene(george);
    }
}
