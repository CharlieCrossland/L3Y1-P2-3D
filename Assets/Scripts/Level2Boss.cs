using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level2Boss : MonoBehaviour
{
    public float moveSpeed;
    public bool bossStart;
    public GameObject carrot;

    [Header("UI")]
    public GameObject StartInfo;
    public GameObject MissionInfo;


    // Start is called before the first frame update
    void Start()
    {
        bossStart = false;
        MissionInfo.SetActive(false);
        StartInfo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (bossStart == true)
        {
            carrot.transform.position += Vector3.left * Time.deltaTime * moveSpeed;
            MissionInfo.SetActive(true);
            StartInfo.SetActive(false);
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
