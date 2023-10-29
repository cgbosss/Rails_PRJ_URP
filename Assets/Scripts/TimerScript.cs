using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0.0f;
    private float currentTime = 0.0f;

    private void Update()
    {
        // Update the timer counting upwards
        timer += Time.deltaTime;
        //UpdateUITimer();
        
        currentTime += Time.deltaTime;
        UpdateTimerText();
    }


    private void UpdateUITimer()
    {
        // Format the timer as a string
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        string milliseconds = ((timer * 100) % 100).ToString("00");

        // Update the UI Text
        timerText.text = minutes + ":" + seconds;
    }

    private void UpdateTimerText()
    {
        int minutes = (int)(currentTime / 60);
        int seconds = (int)(currentTime % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);

        timerText.text = "Time: " + timeString;
    }
}
