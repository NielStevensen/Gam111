using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour {

    public AudioReverbZone Reverb;

    private void OnTriggerEnter(Collider other)
    {
        Reverb.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Reverb.enabled = false ;
    }
}
