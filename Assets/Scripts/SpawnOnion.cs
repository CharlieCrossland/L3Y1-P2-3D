using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnion : MonoBehaviour
{
    public GameObject OnionModel;
    public GameObject OnionModel1;
    public Transform Rot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Onion"))
        {
            Destroy(other.gameObject);
            Vector3 randompoint = new Vector3(Random.Range(11, 14), 29, -10);
            Instantiate(OnionModel, randompoint, Rot.rotation);
        }
        if (other.CompareTag("Onion1"))
        {
            Destroy(other.gameObject);
            Vector3 randompoint1 = new Vector3(Random.Range(3, 9), 29, -11);
            Instantiate(OnionModel1, randompoint1, Rot.rotation);
        }
    }
}
