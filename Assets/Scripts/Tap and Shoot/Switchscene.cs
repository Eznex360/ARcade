using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscene : MonoBehaviour
{
    public string SecretWin;
    public string Win;
    public string Loose;
    void Update()
    {
        if (Data.end)
        {
            if (Data.secretwin)
                SceneManager.LoadScene(SecretWin);
            else if (Data.win)
                SceneManager.LoadScene(Win);
            else
                SceneManager.LoadScene(Loose);
        }
    }
}
