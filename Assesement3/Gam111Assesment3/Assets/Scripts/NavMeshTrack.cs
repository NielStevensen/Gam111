using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTrack : MonoBehaviour
{
    public Transform Target; // object to track
    public float MaxDist; // distance the object wil get closer
    public NavMeshAgent NavMeshBody; // the navmesh component
    Vector3 Towards; // vector towards player

    public Animator Controller;
    enum State { Follow, Idle, Break };
    State current;

    void Start()
    {
        NavMeshBody = GetComponent<NavMeshAgent>();
        Target = GameObject.FindGameObjectWithTag("Player").transform; // set target to player 
    }


    void Update()
    {
        Vector3 Towards = (Target.position - transform.position);  // create vector linking two objects
        if ((Towards.magnitude < MaxDist)) // if within distance of player
        {
            NavMeshBody.speed = 0;
            current = State.Idle;
        }
        else
        {
            NavMeshBody.speed = 3.5f;
            current = State.Follow;
            NavMeshBody.destination = Target.position; // follow player set destinatiopn to player pos
            transform.LookAt(Target); //look towards rthe player
        }


        if (current == State.Follow)
        {
            Controller.SetBool("Walking", true);
        }
        else
        {
            Controller.SetBool("Walking", false);
        }
    }
}