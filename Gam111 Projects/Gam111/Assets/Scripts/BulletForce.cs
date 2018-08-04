using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour {

    public float lifetime;
    public float Magnitude;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().AddForce(Magnitude * transform.forward); // add force when created
        Destroy(gameObject, lifetime); // destroy at end of lifetime
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision Collision) {
        if (Collision.collider.tag != "Terrain")
        {
            Destroy(gameObject); // destroy bullet
        }
	}
}
