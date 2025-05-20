
using UnityEngine;

public class SkyboxTrigger : MonoBehaviour
{
    public Material newSkybox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Or XR Rig
        {
            RenderSettings.skybox = newSkybox;
            DynamicGI.UpdateEnvironment(); // Optional: updates lighting
        }
    }
}
