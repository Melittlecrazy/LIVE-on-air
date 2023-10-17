using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    public GameObject audio1,audio2,audio3,audio4;
    public bool audio_1, audio_2, audio_3, audio_4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && audio_1 == true)
        {
            audio1.SetActive(true); audio2.SetActive(false); audio3.SetActive(false); audio4.SetActive(false);
        }
        if (other.tag == "Player" && audio_2 == true)
        {
            audio1.SetActive(false); audio2.SetActive(true); audio3.SetActive(false); audio4.SetActive(false);
        }
        if (other.tag == "Player" && audio_3 == true)
        {
            audio1.SetActive(false); audio2.SetActive(false); audio3.SetActive(true); audio4.SetActive(false);
        }
        if (other.tag == "Player" && audio_4 == true)
        {
            audio1.SetActive(false); audio2.SetActive(false); audio3.SetActive(false); audio4.SetActive(true);
        }
    }
}
