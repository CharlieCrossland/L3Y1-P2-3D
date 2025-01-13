using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;

    [Header("Collectables")]
    public int requiredCollectables;
    public int currentCollectables;
    public TMP_Text collectablesText;

    [Header("Door")]
    public GameObject door;
    public bool canOpen;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
        Collectables();
    }

    void GameTimer()
    {
        timerText.text = timer.ToString("F2");

        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            timer -= Time.deltaTime;            
        }
    }

    void Collectables()
    {
        collectablesText.text = currentCollectables + " / " + requiredCollectables;

        if (currentCollectables == requiredCollectables)
        {
            canOpen = true;
        }
    }
}
