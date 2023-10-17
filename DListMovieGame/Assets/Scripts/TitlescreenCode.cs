using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitlescreenCode : MonoBehaviour
{
    public string newGame;
    public GameObject button;
    public GameObject cam1;

    public Animation zoom;

    float timer;

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(button);

        timer += 1200.0f;
    }

    private void Update()
    {
        if (timer > 0.0f) timer -= Time.deltaTime;
        if (timer == 0.0f) 
        {
            zoom.Play("camera zoomout");
        }
        return;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(newGame);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
