using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{

    public bool disableMov;
    public bool startTimer;

    [Header("Timer")]
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;
    public GameObject timerOBJ;

    [Header("Scripts")]
    public CarController P1Script;
    public CarControllerP2 P2Script;

    // Start is called before the first frame update
    void Start()
    {
        disableMov = true;
        timer = timeLimit;
        timerOBJ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            gameTimer();
        }

        if (disableMov == true)
        {
            P1Script.enabled = false;
            P2Script.enabled = false;
        }

        if (disableMov == false)
        {
            P1Script.enabled = true;
            P2Script.enabled = true;           
        }
    }

    void gameTimer()
    {
        timerOBJ.SetActive(true);
        timerText.text = timer.ToString("F2");

        if (timer <= 0)
        {
            disableMov = false;
            timerOBJ.SetActive(false);
        }
        else
        {
            timer -= Time.deltaTime;            
        }
    }
}
