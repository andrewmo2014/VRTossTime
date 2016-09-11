using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour {

    public GameObject ball;
    public static int ballsInPlay = 0;
    public float timeSinceLastBallSpawned;
    public float timeBetweenBallSpawns = 0.6f;

    //Constraint UI
    public static int ballsInLevel = 8;
    public static int totalBallsDestroyed = 0;
    public static int totalBallsSpawned;

    public static bool isLoadingScene = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(totalBallsSpawned < ballsInLevel)
        {
            if (timeSinceLastBallSpawned < Time.time)
            {
                if (ballsInPlay < 2)
                {
                    ballsInPlay++;
                    totalBallsSpawned++;
                    SpawnBall();
                    timeSinceLastBallSpawned = Time.time + timeBetweenBallSpawns;
                }
            }
        }

        if( isLoadingScene == false)
        {
            if (totalBallsDestroyed >= ballsInLevel)
            {
                Invoke("LoadLevel", 1);
                isLoadingScene = true;
                ScreenFader.fadeDown = true;
            }
        }

	}

    void LoadLevel()
    {
        GameManager.level++;
        totalBallsDestroyed = 0;
        totalBallsSpawned = 0;
        ballsInPlay = 0;
        GameManager.score = 0;
        SceneManager.LoadScene("Scene" + GameManager.level);
    }

    void SpawnBall()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
}
