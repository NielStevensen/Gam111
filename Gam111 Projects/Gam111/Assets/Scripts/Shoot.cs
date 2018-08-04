using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject Bullet;
    public float delayDuration = 0.1f;
    public float timeOfShot = 0.0f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
        {
            if (Time.time > timeOfShot + delayDuration) // if  enought time has passed
            {
                Instantiate(Bullet, transform.position, transform.rotation); // create bullet
                timeOfShot = Time.time; // log shot time
            }
        }
	}
}
