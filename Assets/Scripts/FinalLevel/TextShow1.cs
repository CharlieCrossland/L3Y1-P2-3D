using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextShow1 : MonoBehaviour
{

    public bool showText;
    public TMP_Text Text1;

    // Start is called before the first frame update
    void Start()
    {
        Text1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (showText)
        {
            Text1.enabled = true;
            Invoke("DisableText", 10f);
        }
    }

    void DisableText()
    {
        Text1.enabled = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            showText = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            showText = false;
        }    
    }
}
