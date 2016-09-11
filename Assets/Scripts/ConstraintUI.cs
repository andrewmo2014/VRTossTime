using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConstraintUI : MonoBehaviour {
    public Text constraintText;

	// Use this for initialization
	void Start () {
        constraintText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        constraintText.text = "Balls:\n" + (BallSpawner.ballsInLevel - BallSpawner.totalBallsDestroyed);
	}
}
