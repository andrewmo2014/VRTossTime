using UnityEngine;
using System.Collections;

public class BouncyWall : MonoBehaviour {

	void OnCollisionEnter()
    {
        GameManager.score += 2;
    }
}
