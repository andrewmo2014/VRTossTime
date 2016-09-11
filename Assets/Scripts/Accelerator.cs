using UnityEngine;
using System.Collections;

public class Accelerator : MonoBehaviour {

    public Vector3 colRigidVel;
    public float speedUpAmount = 3;

	void OnTriggerEnter(Collider col)
    {
        colRigidVel = col.GetComponent<Rigidbody>().velocity;
        col.GetComponent<Rigidbody>().velocity = new Vector3(colRigidVel.x, colRigidVel.y, colRigidVel.z) * speedUpAmount;
    }
}
