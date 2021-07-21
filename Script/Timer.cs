using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool stopTime = false;
    public Text Record;
    private float MaxScore;

    void Start()
    {
        startTime = Time.time;
        GetComponent<Text>().text = PlayerPrefs.GetInt("timerText").ToString();
        Record.text = PlayerPrefs.GetString("savescore");
        MaxScore = PlayerPrefs.GetFloat("savescore");

    }

    void Update()
    {
        
        // Таймер
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("0");

        timerText.text = minutes + ":" + seconds;
        if (stopTime)
        {
            return;
        }


        // Запись рекорда
        if (t > MaxScore)
        {
            MaxScore = t;
            PlayerPrefs.SetString("savescore", MaxScore.ToString("0"));
            PlayerPrefs.Save();
        }
        
    }
}
