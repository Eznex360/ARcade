using UnityEngine;
using UnityEngine.UI;
public class normal : MonoBehaviour
{
    public Button Button;
    public static bool difficulty;
    void Start()
    {
        Button.onClick.AddListener(Load);
    }

    void Load()
    {
        difficulty = true;
    }
}
