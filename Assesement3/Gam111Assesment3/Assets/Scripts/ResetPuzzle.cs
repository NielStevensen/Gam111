using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPuzzle : MonoBehaviour
{

    public GameObject[] lights;

    void Restart()
    {
        lights[0].SetActive(false);
        lights[1].SetActive(true);
        lights[2].SetActive(true);
        lights[3].SetActive(true);
        lights[4].SetActive(true);
        lights[5].SetActive(false);
    }
}