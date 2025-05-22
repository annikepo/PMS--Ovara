
using UnityEngine;

public class StartButtonTeleport : MonoBehaviour
{
    public Transform trackingSpace;   // <- Assign [BuildingBlock] Camera Rig → TrackingSpace
    public Transform targetSpot;      // <- Assign Spot 1

    public void MoveToSpotOne()
    {
        Debug.Log("Teleport triggered");

        if (trackingSpace != null && targetSpot != null)
        {
            trackingSpace.position = targetSpot.position;
            Debug.Log("Teleported to Spot 1");
        }
        else
        {
            Debug.LogWarning("Missing trackingSpace or targetSpot");
        }
    }
}
