
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject checkInPanel;
    public GameObject recommendationPanel;

    [Header("XR Teleport Targets")]
    public Transform trackingSpace; // XR Origin / XR Rig parent object
    public Transform spot1;         // AmazingForest
    public Transform spot2;         // GlowingMushroom
    public Transform spot3;         // IslandInTheNight

    // Called by the Start button
    public void StartGame()
    {
        Debug.Log("Start button pressed");
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
        if (checkInPanel != null) checkInPanel.SetActive(true);
    }

    // Called by emotion buttons (Irritable, Unstable, etc.)
    public void OnEmotionSelected(string emotion)
    {
        Debug.Log("Selected Emotion: " + emotion);
        if (checkInPanel != null) checkInPanel.SetActive(false);
        if (recommendationPanel != null) recommendationPanel.SetActive(true);
        PlayerPrefs.SetString("SelectedEmotion", emotion); // optional memory
    }

    // Called by location buttons
    public void OnRecommendationSelected(string location)
    {
        Debug.Log("Selected Location: " + location);
        if (recommendationPanel != null) recommendationPanel.SetActive(false);

        switch (location)
        {
            case "AmazingForest":
                TeleportTo(spot1);
                break;
            case "GlowingMushroom":
                TeleportTo(spot2);
                break;
            case "IslandInTheNight":
                TeleportTo(spot3);
                break;
            default:
                Debug.LogWarning("Unknown location string: " + location);
                break;
        }
    }

    // Handles the teleportation
    void TeleportTo(Transform target)
    {
        if (trackingSpace != null && target != null)
        {
            trackingSpace.position = target.position;
            trackingSpace.rotation = target.rotation;
            Debug.Log("Teleported to: " + target.name);
        }
        else
        {
            Debug.LogWarning("Teleport failed: Missing trackingSpace or target transform");
        }
    }
}
