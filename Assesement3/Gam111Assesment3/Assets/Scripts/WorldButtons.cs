using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldButtons : MonoBehaviour {

    RaycastHit Hits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
           Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           Physics.Raycast(Ray, out Hits);
            if (Hits.transform.GetComponent<MultipleLights>() != null)
            {
                Hits.transform.GetComponent<MultipleLights>().Invoke("LightSwitch", 0);
            }

            if (Hits.transform.GetComponent<ResetPuzzle>() != null)
            {
                Hits.transform.GetComponent<ResetPuzzle>().Invoke("Restart", 0);
            }
        }
	}
}
