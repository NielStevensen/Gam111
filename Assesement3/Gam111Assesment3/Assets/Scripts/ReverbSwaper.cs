using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverbSwaper : MonoBehaviour
{
    bool InHouse = false;
    public AudioReverbZone Inside;
    public AudioReverbZone Outside;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            InHouse = !InHouse; // change weter the player is inside
            Inside.enabled = InHouse; // set the inside reverb to be active insde house
            Outside.enabled = !InHouse; //set the outside reverb to be active outside house
        }
    }
}
