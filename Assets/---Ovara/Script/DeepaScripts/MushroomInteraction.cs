
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class MushroomInteraction : MonoBehaviour
{
    public Color nearColor = Color.blue;
    public Color farColor = new Color(0.82f, 0.71f, 0.55f);
    public float detectionRange = 6f;
    private Renderer mushroomRenderer;
    private Transform player;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    void Start()
    {
        mushroomRenderer = GetComponentInChildren<Renderer>();
        player = Camera.main.transform;

        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.selectExited.AddListener(OnGrabExit);
        }
        else
        {
            Debug.LogError("XRGrabInteractable component missing!");
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        mushroomRenderer.material.color = (distance <= detectionRange) ? nearColor : farColor;
    }

    void OnGrabExit(SelectExitEventArgs args)
    {
       
        Destroy(gameObject); // Remove mushroom after fading
    }
}


