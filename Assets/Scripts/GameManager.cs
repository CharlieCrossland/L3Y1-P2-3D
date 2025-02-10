using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Collectables")]
    public int requiredCollectables;
    public int currentCollectables;
    public GameObject Key;
    public bool mission;

    [Header("Door")]
    public GameObject door;
    public bool canOpen;

    // Start is called before the first frame update
    void Start()
    {
        canOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collectables();
        KeyShow();

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Collectables()
    {

        if (currentCollectables == requiredCollectables)
        {
            canOpen = !canOpen;
            currentCollectables = 0;
        }
        if (currentCollectables == requiredCollectables && mission)
        {
            Debug.Log("End");
        }
    }

    void KeyShow()
    {
        if (canOpen == true)
        {
            Key.SetActive(true);
        }
        else
        {
            Key.SetActive(false);
        }
    }
}
