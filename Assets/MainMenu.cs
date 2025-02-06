using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Canvas MainScreen;
    public Canvas SelectMode;
    public Canvas CreditScreen;

    // Start is called before the first frame update
    void Start()
    {
        MainScreen.enabled = true;
        SelectMode.enabled = false;
        CreditScreen.enabled = false;
    }


    public void Play()
    {
        MainScreen.enabled = false;
        SelectMode.enabled = true;
    }

    public void Singleplayer()
    {
        SceneManager.LoadScene("Level1 - Fridge");
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene("Track 1");
    }

    public void OnBackToMain()
    {
        MainScreen.enabled = true;
        SelectMode.enabled = false;
        CreditScreen.enabled = false;
    }

    public void Credits()
    {
        MainScreen.enabled = false;
        CreditScreen.enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
