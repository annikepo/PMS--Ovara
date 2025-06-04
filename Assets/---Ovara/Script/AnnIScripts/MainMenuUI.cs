
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject checkInPanel;
    public GameObject recommendationPanel; // this can stay in isdkovara menu

    [Header("XR Teleport Targets")]
    public Transform trackingSpace;   // XR Origin or XR Rig
    public Transform spot1;           // AmazingForest
    public Transform spot2;           // GlowingMushroom
    public Transform spot3;           // IslandInTheNight

    [Header("isdkovara Menu")]
    public GameObject isdkovaraMenu;  // Set this to your isdkovara menu parent GameObject

    void Start()
    {
        if (isdkovaraMenu != null)
        {
            isdkovaraMenu.SetActive(false); // Hide at start
        }
    }

    // Called when "Start" is pressed
    public void StartGame()
    {
        Debug.Log("Start button pressed");
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
        if (checkInPanel != null) checkInPanel.SetActive(true);
    }

    // Called when an emotion is selected
    public void OnEmotionSelected(string emotion)
    {
        Debug.Log("Selected Emotion: " + emotion);
        if (checkInPanel != null) checkInPanel.SetActive(false);

        if (isdkovaraMenu != null)
        {
            isdkovaraMenu.SetActive(true); // Show isdkovara menu
        }

        PlayerPrefs.SetString("SelectedEmotion", emotion); // Optional save
    }

    // Called when a recommendation is selected
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

    // Teleport user to a location
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
            Debug.LogWarning("Teleport failed: trackingSpace or target is null");
        }
    }
}
