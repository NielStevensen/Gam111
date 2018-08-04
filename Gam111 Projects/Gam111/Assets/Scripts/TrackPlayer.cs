using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour {

    public Transform Target;
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Target); // looks as target invert x scaling for ui elements
	}
}
