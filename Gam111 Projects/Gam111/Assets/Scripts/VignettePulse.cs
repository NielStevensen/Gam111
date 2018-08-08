using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VignettePulse : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette Abiration;

    void Start()
    {
        Abiration = ScriptableObject.CreateInstance<Vignette>();
        Abiration.enabled.Override(true);
        Abiration.intensity.Override(1f);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, Abiration);
    }

    void Update()
    {
        Abiration.intensity.value = (Mathf.Sin(Time.realtimeSinceStartup) + 1.0f)* 100;
    }

    void Destroy()
    {
        RuntimeUtilities.DestroyVolume(m_Volume, true);
    }
}
