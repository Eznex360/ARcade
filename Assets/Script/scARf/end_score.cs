using System;
using TMPro;
using UnityEngine;

public class end_score : MonoBehaviour
{
    public TextMeshProUGUI score;

    private void Update()
    {
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        score.text = MouthTrigger.Score.ToString("000");
    }
}
