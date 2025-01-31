using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{

    public Countdown countScript;

    public float timer;
    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            countScript.startTimer = true;
        }
        else
        {
            timer -= Time.deltaTime;            
        }
    }
}
