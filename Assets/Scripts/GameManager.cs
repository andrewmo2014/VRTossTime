using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static int score = 0;
    public static int level = 0;

	// Use this for initialization
	void Start () {
	
	}

    void OnLevelWasLoaded()
    {
        BallSpawner.totalBallsDestroyed = 0;
        BallSpawner.totalBallsSpawned = 0;
        BallSpawner.ballsInPlay = 0;

        ScreenFader.fadeDown = false;
        ScreenFader.fadeUp = true;
        BallSpawner.isLoadingScene = false;
    }
	
	
}
