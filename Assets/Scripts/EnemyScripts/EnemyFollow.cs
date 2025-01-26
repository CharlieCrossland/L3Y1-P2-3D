using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public bool close;
    public float moveSpeed;

    [Header("Player")]
    public Vector3 player;
    public Quaternion playerR;
    public GameObject playerOBJ;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        Pos();
    }

    void Follow()
    {
        if (close == true)
        {
            transform.position = player;
        }
    }


    void Pos()
    {
        player = playerOBJ.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            close = true;
        }
    }
}
