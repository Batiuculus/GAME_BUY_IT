using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Threading;

public class End : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;
    public GameObject END;
    public GameObject StopTime;
    public GameObject StopAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Target1 == false) && (Target2 == false) && (Target3 == false) && (Target4 == false))
        {
            END.GetComponent<Text>().text = "Congrats! You found all of them!"+"\r\n"+"Press G to go back home now...";
            Destroy(StopTime);
            Destroy(StopAudio);
        }
    }
}
