using UnityEngine;

[ExecuteAlways]
public class LightingController : MonoBehaviour
{
    public Light sun;
    [Range(0,1)] public float time = 0.5f;

    void Update()
    {
        if (sun == null) return;
        sun.color = Color.Lerp(Color.white, new Color(0.2f, 0.2f, 0.4f), time);
        sun.intensity = Mathf.Lerp(1.2f, 0.3f, time);
    }
}