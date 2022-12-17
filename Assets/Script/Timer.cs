using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Timer : MonoBehaviour
{
    public GameObject TimerText;
    public float timeAtStart;
    public GameObject LoseText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTimer());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    IEnumerator CountDownTimer()
    {
        while (timeAtStart >= 0.0f)
        {
            timeAtStart -= Time.deltaTime;
            int timeInSeconds = Mathf.RoundToInt(timeAtStart);
            TimerText.GetComponent<Text>().text = "TIME LEFT:" + timeInSeconds;
            if(timeAtStart <= 0.0f)
            {
                timeAtStart = 0;
                LoseText.GetComponent<Text>().text = "TIME IS UP";
                break;
            }
            yield return null;
        }
    }
}
