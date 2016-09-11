using UnityEngine;
using System.Collections;

public class BallVariables : MonoBehaviour {

    public bool hasHitWall = false;

	void FixedUpdate()
    {
        if(transform.position.y < -30 )
        {
            Destroy(gameObject);
            BallSpawner.ballsInPlay--;
            BallSpawner.totalBallsDestroyed++;
        }
    }
}
