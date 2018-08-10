using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleLights : MonoBehaviour {

    public GameObject[] lights;
    public int[] connected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LightSwitch()
    {
        foreach (int a in connected)
        {
            if (lights[a].activeInHierarchy)
            {
                lights[a].SetActive(false);
            }
            else
            {
                lights[a].SetActive(true);
            }
        }
    }
}
