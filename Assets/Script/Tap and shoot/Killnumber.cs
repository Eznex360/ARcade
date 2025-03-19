using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Killnumber : MonoBehaviour
{
    // Update is called once per frame
    public TextMeshProUGUI Text;
    void Update()
    {
        Text.text = PNJController.count.ToString();
    }
}
