using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public CarController carScripts;

    public SpeedBoost boostScript;

    public bool activeEnd;

    public GameObject Wall;
    public GameObject returnPoint;

    // Start is called before the first frame update
    void Start()
    {
        activeEnd = false;
        Wall.SetActive(false);
        returnPoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (activeEnd)
        {
            //carScript.maxSpeed = 9f;
            //carScript.forwardAccel = 3.5f;
            //carScript.reverseAccel = 2f;

            Wall.SetActive(true);
            returnPoint.SetActive(true);

            boostScript.active = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activeEnd = true;
        }
    }
}
