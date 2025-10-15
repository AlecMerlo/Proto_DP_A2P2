using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Clouds : MonoBehaviour
{
    public UniversalAdditionalLightData clouds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clouds.lightCookieOffset += new Vector2(0.3f, 0.12f) * Time.deltaTime * 0.5f;
    }
}
