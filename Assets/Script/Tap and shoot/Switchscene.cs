using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscene : MonoBehaviour
{
    public string SceneNameSecretWin;
    public string SceneNamewin;
    public string SceneNameloose;
    void Update()
    {
        if (Data.end)
        {
            if (Data.secret)
                SceneManager.LoadScene(SceneNameSecretWin);
            else
            {
                if (Data.win)
                    SceneManager.LoadScene(SceneNamewin);
                else
                    SceneManager.LoadScene(SceneNameloose);
            }
        }
    }
}