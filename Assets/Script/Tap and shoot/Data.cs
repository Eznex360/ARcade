using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Data : MonoBehaviour
{ 
    public TextMeshProUGUI timerText;
    public float totalTimeInSeconds = 60.0f;
    private float elapsedTimeInSeconds;
    public static bool win = false;
    public static bool secret = false;
    public static bool end = false;

    private void Start()
    {
        elapsedTimeInSeconds = 0.0f;
    } 
    private void Update()
    {
        if (elapsedTimeInSeconds < totalTimeInSeconds)
        {
            elapsedTimeInSeconds += Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            end = true;
            if (PNJController.count == 50)
                secret = true;
            if (PNJController.count >= 15)
                win = true;
            if (PNJController.count < 15)
                win = false;
        }
    } 
    private void UpdateTimerUI()
    { 
        float timeRemainingInSeconds = totalTimeInSeconds - elapsedTimeInSeconds;
        int minutes = Mathf.FloorToInt(timeRemainingInSeconds / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemainingInSeconds % 60.0f);
        timerText.text = seconds.ToString("00");
    }
}