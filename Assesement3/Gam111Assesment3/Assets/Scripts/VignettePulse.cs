using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VignettePulse : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette Vignette;

    void Start()
    {
        Vignette = ScriptableObject.CreateInstance<Vignette>();
        Vignette.enabled.Override(true);
        Vignette.intensity.Override(1f);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, Vignette);
    }

    void Update()
    {
        Vignette.intensity.value = (Mathf.Sin(Time.realtimeSinceStartup) + 1.0f);
    }

    void Destroy()
    {
        RuntimeUtilities.DestroyVolume(m_Volume, true);
    }
}
