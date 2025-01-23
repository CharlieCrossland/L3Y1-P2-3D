using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public CarController carScript;

    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            carScript.maxSpeed = 28;
            carScript.forwardAccel = 6;
            carScript.reverseAccel = 0;
        }

        if (active == false)
        {
            carScript.maxSpeed = 9;
            carScript.forwardAccel = 3.5f;
            carScript.reverseAccel = 2;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            active = true;
        }
    }
}
