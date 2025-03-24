using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Data : MonoBehaviour
{ 
    public TextMeshProUGUI timerText;
    public static float totalTimeInSeconds = 30.0f;
    private float elapsedTimeInSeconds;
    public static bool win = false;
    public static bool secret = false;
    public static bool end = false;

    private void Start()
    {
        StartCoroutine(WaitForARCamera());
    }

    IEnumerator WaitForARCamera()
    {
        while (Camera.main == null || !Camera.main.enabled)
        {
            yield return null;
        }
        elapsedTimeInSeconds = 0.0f;
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (elapsedTimeInSeconds < totalTimeInSeconds)
        {
            elapsedTimeInSeconds += Time.deltaTime;
            UpdateTimerUI();
            yield return null;
        }
        if (easy.difficulty)
            load_difficulty(15);
        if (normal.difficulty)
            load_difficulty(25);
        if (hard.difficulty)
            load_difficulty(40);
    }

    private void load_difficulty(int x)
    {
        end = true;
        if (PNJController.count == 50)
            secret = true;
        if (PNJController.count >= x)
            win = true;
        if (PNJController.count < x)
            win = false;
    }

    private void UpdateTimerUI()
    { 
        float timeRemainingInSeconds = totalTimeInSeconds - elapsedTimeInSeconds;
        int minutes = Mathf.FloorToInt(timeRemainingInSeconds / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemainingInSeconds % 60.0f);
        timerText.text = seconds.ToString("00");
    }
}