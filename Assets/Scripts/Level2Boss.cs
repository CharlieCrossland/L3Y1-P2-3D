using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Boss : MonoBehaviour
{
    public float moveSpeed;
    public bool bossStart;
    public GameObject carrot;

    // Start is called before the first frame update
    void Start()
    {
        bossStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossStart == true)
        {
            carrot.transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bossStart = true;
        }
    }
}
