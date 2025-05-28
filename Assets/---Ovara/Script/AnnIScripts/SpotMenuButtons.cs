
using UnityEngine;

public class SpotMenuButtons : MonoBehaviour
{
    public Transform trackingSpace;
    public Transform mainMenuLocation;
    public Transform navigationMapLocation;

    public void GoToMainMenu()
    {
        TeleportTo(mainMenuLocation);
    }

    public void GoToNavigationMap()
    {
        TeleportTo(navigationMapLocation);
    }

    private void TeleportTo(Transform target)
    {
        if (trackingSpace != null && target != null)
        {
            trackingSpace.position = target.position;
            trackingSpace.rotation = target.rotation;
            Debug.Log("Teleported to: " + target.name);
        }
        else
        {
            Debug.LogWarning("Missing target or tracking space!");
        }
    }
}
