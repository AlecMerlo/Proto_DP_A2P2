using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Clouds : MonoBehaviour
{
    public UniversalAdditionalLightData clouds;

    // Update is called once per frame
    void Update()
    {
        clouds.lightCookieOffset += new Vector2(0.3f, 0.12f) * Time.deltaTime * 0.5f;
    }
}
