using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSolution : MonoBehaviour {

    public GameObject[] Prerequsites;
    bool complete;

    // Use this for initialization
    void Start () {
        complete = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!complete)// if the puzzle is not finished yet
        {
            complete = true; // flag as complete until disproven
            foreach (GameObject test in Prerequsites)
            {
                if (!test.activeInHierarchy)
                {
                    complete = false; //if a light is off the puzzle is incomplete
                }
            }
            if (complete) // if the puzzle is complete after checking
            {
                // do stuff
                Debug.Log("Complete");
            }
        }
	}
}
