using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GlobalVolumeChange globalVolumeChange;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            startPos = transform.position;
        }
        if (other.CompareTag("KillPlayer"))
        {
            transform.position = startPos;
        }
        if (other.CompareTag("KillPlayerResetScene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.CompareTag("Lighting"))
        {
            globalVolumeChange.lightChange = true;
        }
        if (other.CompareTag("CabbageJumpscare"))
        {
            SceneManager.LoadScene("CabbageJumpscare");
        }
    }
}
