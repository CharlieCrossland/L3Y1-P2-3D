using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Script")]
    public GameManager managerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && managerScript.canOpen == true)
        {
            Destroy(gameObject);
        }
    }
}
