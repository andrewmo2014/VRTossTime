using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

    public float speed;
    public Transform objectTransform;
    public Rigidbody objectRigidbody;

    public float objectP;
    public bool movingLeft;

	// Use this for initialization
	void Start () {
        objectTransform = GetComponent<Transform>();
        objectRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        objectP = objectTransform.position.x;
        if(objectP > 4)
        {
            movingLeft = true;
        }
        if(objectP < -4)
        {
            movingLeft = false;
        }
        if( movingLeft)
        {
            objectRigidbody.MovePosition(transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * speed);
        }
        else
        {
            objectRigidbody.MovePosition(transform.position + new Vector3(1, 0, 0) * Time.deltaTime * speed);

        }
    }

    void OnTriggerEnter()
    {
        speed += 1;
    }
}
