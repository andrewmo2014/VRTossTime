using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
    public ParticleSystem goalParticles;

	void OnTriggerEnter (Collider col)
    {
        if(col.tag == "Ball")
        {
            GameManager.score += 5;
            Destroy(col.gameObject);
            BallSpawner.ballsInPlay--;
            BallSpawner.totalBallsDestroyed++;
            goalParticles.Play();
            Invoke("StopParticles", 1);
        }
    }

    void StopParticles()
    {
        goalParticles.Stop();
    }
	
}
