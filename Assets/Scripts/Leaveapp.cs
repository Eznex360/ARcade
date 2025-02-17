using UnityEngine;
using UnityEngine.UI;

public class Leaveapp : MonoBehaviour
{
    private Button Quit;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(Application.Quit);
    }
}
