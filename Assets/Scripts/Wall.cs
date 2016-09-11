using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	void OnCollisionEnter( Collision col)
    {
        if( col.gameObject.CompareTag("Ball"))
        {
            if( !col.gameObject.GetComponent<BallVariables>().hasHitWall)
            {
                GameManager.score++;
                col.gameObject.GetComponent<BallVariables>().hasHitWall = true;
            }
        }
    }
}
