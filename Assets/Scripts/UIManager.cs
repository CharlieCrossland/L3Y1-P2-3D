using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Scripts")]
    public Level2Boss BossScript02;
    
    [Header("UI")]
    public TMP_Text level2BossInfo;

    // Start is called before the first frame update
    void Start()
    {
        level2BossInfo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        level2Boss();
    }

    void level2Boss()
    {
        if (BossScript02.bossStart == true)
        {
            level2BossInfo.enabled = true;
        }

        if (BossScript02.bossStart == false)
        {
            level2BossInfo.enabled = false;
        }
    }
}
