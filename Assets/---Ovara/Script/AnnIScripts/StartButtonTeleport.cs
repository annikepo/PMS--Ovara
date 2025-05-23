
using UnityEngine;

public class StartButtonTeleport : MonoBehaviour
{
    public Transform trackingSpace;   // Assign: TrackingSpace
    public Transform targetSpot;      // Assign: Spot 1
    public GameObject menuCanvas;     // Assign: the UI Canvas with all buttons

    public void MoveToSpotOne()
    {
        Debug.Log("Start button clicked");

        if (trackingSpace != null && targetSpot != null)
        {
            trackingSpace.position = targetSpot.position;
            Debug.Log("Teleported to Spot 1");
        }

        if (menuCanvas != null)
        {
            menuCanvas.SetActive(false); // Hide menu
            Debug.Log("Menu hidden");
        }
    }
}
