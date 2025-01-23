using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering;
//using UnityEngine.Rendering.Universal;

public class GlobalVolumeChange : MonoBehaviour
{
    public GameObject ColorAdjust;

    public bool lightChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lightChange == true)
        {
            ColorAdjust.SetActive(true);
        }
        
        if (lightChange == false)
        {
            ColorAdjust.SetActive(false);
        }
    }
}
