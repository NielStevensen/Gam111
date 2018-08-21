using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTrack : MonoBehaviour
{
    public Transform Target; // object to track
    public float WalkDist; // distance the object wil get closer
    public float RunDist; // distance the object wil get closer
    public NavMeshAgent NavMeshBody; // the navmesh component
    Vector3 Towards; // vector towards player

    public Animator Controller;
    enum State { Walk, Idle, Play };
    State current;

    void Start()
    {
        NavMeshBody = GetComponent<NavMeshAgent>();
        Target = GameObject.FindGameObjectWithTag("Player").transform; // set target to player 
    }


    void Update()
    {
        Vector3 Towards = (Target.position - transform.position);  // create vector linking two objects
        if ((Towards.magnitude < WalkDist)) // if within distance of player
        {
            NavMeshBody.speed = 0;
            current = State.Idle;
        }
        else
        {
            NavMeshBody.speed = 3.5f;
            current = State.Walk;
            NavMeshBody.destination = Target.position; // follow player set destinatiopn to player pos
        }


        if (current == State.Walk)
        {     
            if ((Towards.magnitude > RunDist))
            {
                Controller.SetBool("Walking", true);
                Controller.SetBool("Running", true);
            }
            else
            {
                Controller.SetBool("Walking", true);
                Controller.SetBool("Running", false);
            }
        }
        else
        {
            Controller.SetBool("Running", false);
            Controller.SetBool("Walking", false);
        }
    }
}