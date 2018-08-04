using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAssist : MonoBehaviour {

    public Transform Target;
    public float Magnitude = 100.0f;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        Target = GameObject.FindWithTag("Enemy").transform;
        Rigidbody rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 toTarget;
        if (Target != null)
        {
            toTarget = Vector3.Normalize(Target.position - transform.position);
            rb.AddForce(toTarget * Magnitude);
        }
	}
}
