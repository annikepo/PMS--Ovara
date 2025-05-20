using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MushroomInteraction : MonoBehaviour
{
    public Color nearColor = Color.blue;
    public Color farColor = Color.red;
    public float detectionRange = 3f;
    private Renderer mushroomRenderer;
    private Transform player;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    void Start()
    {
        // Set up renderer for color change
        mushroomRenderer = GetComponent<Renderer>();
        player = Camera.main.transform; // Assuming first-person player

        // Set up grab interaction
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.selectExited.AddListener(OnPickedUp);
        }
        else
        {
            Debug.LogError("XRGrabInteractable component missing!");
        }
    }

    void Update()
    {
        // Change color based on distance
        float distance = Vector3.Distance(transform.position, player.position);
        mushroomRenderer.material.color = (distance <= detectionRange) ? nearColor : farColor;
    }

    void OnPickedUp(SelectExitEventArgs args)
    {
        Destroy(gameObject); // Makes the mushroom disappear when picked
    }
}
