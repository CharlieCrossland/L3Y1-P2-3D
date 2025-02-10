using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("Scripts")]
    public CarController PScript;
    
    [Header("PauseMenu")]
    public Canvas PMenu;
    public Canvas Confirm;
    public bool paused;

    // Start is called before the first frame update
    void Start()
    {
        PMenu.enabled = false;
        Confirm.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PMenu.enabled = true;
            PScript.enabled = false;
        }
    }

    public void GoToConfirm()
    {
        PMenu.enabled = false;
        Confirm.enabled = true;
    }

    public void ConfirmAction()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackFromConfirm()
    {
        PMenu.enabled = true;
        Confirm.enabled = false;
    }

    public void BackToGame()
    {
        PMenu.enabled = false;
        PScript.enabled = true;
    }
}
