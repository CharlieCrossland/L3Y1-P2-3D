using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public bool pointCheck;
    public bool dead;
    public GameObject Player;
    Vector3 startPos;

    void Start()
    {
        startPos = Player.transform.position;
    }

    void Update()
    {
        if (pointCheck)
        {
            startPos = Player.transform.position;
        }
        if (dead)
        {
            Player.transform.position = startPos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pointCheck = true;
        }
        else
        {
            pointCheck = false;
        }
    }
}
