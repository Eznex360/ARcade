using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button ButtonScene;
    public string SceneName;
    void Start()
    {
        ButtonScene.onClick.AddListener(Load);
    }

    void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
}
