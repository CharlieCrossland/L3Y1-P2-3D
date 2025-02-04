using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Collider : MonoBehaviour
{
    public GlobalVolumeChange globalVolumeChange;
    public Vector3 startPos;
    public bool Finish;

    [Header("Sound")]
    public AudioSource doorSFX;
    public AudioSource keySFX;
    public AudioSource dieSFX;

    [Header("Script")]
    public CarControllerP2 P2Script;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Finish = false;
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
            dieSFX.Play();
            transform.position = startPos;
        }
        if (other.CompareTag("KillPlayerResetScene"))
        {
            dieSFX.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.CompareTag("Lighting"))
        {
            globalVolumeChange.lightChange = true;
        }
        if (other.CompareTag("CabbageJumpscare"))
        {
            dieSFX.Play();
            SceneManager.LoadScene("CabbageJumpscare");
        }
        if (other.CompareTag("Key"))
        {
            keySFX.Play();
        }
        if (other.CompareTag("Door"))
        {
            doorSFX.Play();
        }
        if (other.CompareTag("MPBoost"))
        {
            P2Script.hitBoost = true;
        }
        if (other.CompareTag("MPEnd"))
        {
            Finish = true;
        }
    }
}
