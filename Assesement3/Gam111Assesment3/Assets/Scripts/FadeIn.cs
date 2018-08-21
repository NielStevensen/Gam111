using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class FadeIn : MonoBehaviour {

    public Text Intro;
    public Image Reticle;
    PostProcessVolume m_Volume;
    Vignette Vignette;
    float current = 100;

    // Use this for initialization
    void Start () {
        Intro.enabled = true;

        Vignette = ScriptableObject.CreateInstance<Vignette>();
        Vignette.enabled.Override(true);
        Vignette.intensity.Override(100f);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 1f, Vignette);
    }
	
	// Update is called once per frame
	void Update () {
        if (current > .5f)
        {
            current -= (10 * Time.deltaTime);
        }
        else
        {
            current = .5f;
            Intro.enabled = false;
            Reticle.enabled = true;
        }
        Vignette.intensity.value = current;
    }
}
