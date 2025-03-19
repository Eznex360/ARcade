using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SplashVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "all_menu";

    void Start()
    {
        videoPlayer.loopPointReached += EndReached;
        videoPlayer.Play();
    }

    void EndReached(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }
}