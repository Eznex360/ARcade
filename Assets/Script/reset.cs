using UnityEngine;

public class reset : MonoBehaviour
{
    void Start()
    {
        Data.secret = false;
        Data.win = false;
        Data.end = false;
        Data.totalTimeInSeconds = 30f;
        PNJController.count = 0;
        easy.difficulty = false;
        normal.difficulty = false;
        hard.difficulty = false;
        MouthTrigger.DestroyCount = 0;
        ObjectMover.loose = false;
        ObjectMover.speed = 0.5f;
        ObjectSpawner.spawnInterval = 3f;
        MouthTrigger.DestroyCount = 0;
        MouthTrigger.Score = 0;

    }
}
