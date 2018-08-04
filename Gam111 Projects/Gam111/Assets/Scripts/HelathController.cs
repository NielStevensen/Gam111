using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelathController : MonoBehaviour {

    public int Health;
    public Text HealthDisplay;

    public void Start()
    {
        DrawHealth();// run draw health function
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health --;  // subtract 1 health
        if (Health <= 0) Destroy(gameObject); // if health is 0 or lower destroy
        DrawHealth();  // run draw health function
    }

    public void DrawHealth()
    {
        if (HealthDisplay != null) // if an object is specified
        {
            HealthDisplay.text = "Lives: " + Health; // print Lives: + health number
        }
    }
}

