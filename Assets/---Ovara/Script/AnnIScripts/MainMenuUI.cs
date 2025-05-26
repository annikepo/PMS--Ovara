
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject checkInPanel;
    public GameObject recommendationPanel;

    [Header("XR Teleport Targets")]
    public Transform trackingSpace; // Usually your XR rig or XR Origin
    public Transform spot1; // Forest
    public Transform spot2; // Beach
    public Transform spot3; // Island

    // Called by Start button
    public void StartGame()
    {
        mainMenuPanel.SetActive(false);
        checkInPanel.SetActive(true);
    }

    // Called by Emotion buttons (Irritable, etc.)
    public void OnEmotionSelected(string emotion)
    {
        Debug.Log("Selected Emotion: " + emotion);
        checkInPanel.SetActive(false);
        recommendationPanel.SetActive(true);
        PlayerPrefs.SetString("Emotion", emotion); // optional
    }

    // Called by Location buttons (Forest, Beach, Island)
    public void OnRecommendationSelected(string location)
    {
        Debug.Log("Selected Location: " + location);
        recommendationPanel.SetActive(false);

        switch (location)
        {
            case "Forest":
                TeleportTo(spot1);
                break;
            case "Beach":
                TeleportTo(spot2);
                break;
            case "Island":
                TeleportTo(spot3);
                break;
        }
    }

    void TeleportTo(Transform target)
    {
        if (trackingSpace != null && target != null)
        {
            trackingSpace.position = target.position;
            trackingSpace.rotation = target.rotation;
        }
        else
        {
            Debug.LogWarning("Teleport target or tracking space is missing!");
        }
    }
}
