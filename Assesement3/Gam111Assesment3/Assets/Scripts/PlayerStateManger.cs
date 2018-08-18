using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManger : MonoBehaviour {

    public Animator Controller;
    enum State {Follow, Idle, Break};
    State current;
	
	// Update is called once per frame
	void Update () {
        GameObject Follow = GameObject.FindGameObjectWithTag("Player");

        if((transform.position - Follow.transform.position).magnitude > 2.5)
        {
            current = State.Follow;
        }
        else
        {
            current = State.Idle;
        }
        Debug.Log((transform.position - Follow.transform.position).magnitude);
        if ( current == State.Follow)
        {
            Controller.SetBool("Walking", true);
        }
        else
        {
            Controller.SetBool("Walking", false);
        }
    }
}
