using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [Header("Script")]
    public CheckPoints checkScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkScript.dead = true;
        }
        else
        {
            checkScript.dead = false;
        }
    }
}
