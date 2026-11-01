using UnityEngine;


[RequireComponent(typeof(Light))]
public class TorchFlicker : MonoBehaviour
{
    public float baseIntensity = 3f;
    public float flickerAmount = 0.5f;
    public float flickerSpeed = 8f;

    private Light torchLight;

    void Start()
    {
        torchLight = GetComponent<Light>();
    }

    void Update()
    {
        float flicker = Mathf.PerlinNoise(
            Time.time * flickerSpeed, 0f
        );

        torchLight.intensity =
            baseIntensity + (flicker - 0.5f) * 2f * flickerAmount;
    }
}

