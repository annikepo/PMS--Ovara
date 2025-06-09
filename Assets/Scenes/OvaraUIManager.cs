
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OvaraUIManager : MonoBehaviour
{
    public GameObject welcomePanel, mainMenuPanel, checkInPanel, recommendationPanel;
    public Transform trackingSpace, spot1, spot2, spot3;

    void Start() => ShowPanel(welcomePanel);

    public void ContinueFromWelcome() => ShowPanel(mainMenuPanel);
    public void OnStartPressed() => ShowPanel(checkInPanel);

    public void OnEmotionSelected(string emotion)
    {
        Debug.Log("Emotion: " + emotion);
        ShowPanel(recommendationPanel);
    }

    public void OnSpotSelected(string location)
    {
        Transform target = location switch
        {
            "Spot1" => spot1,
            "Spot2" => spot2,
            "Spot3" => spot3,
            _ => null
        };

        if (target != null)
        {
            trackingSpace.position = target.position;
            trackingSpace.rotation = target.rotation;
        }

        recommendationPanel.SetActive(false);
    }

    public void QuitGame() => Application.Quit();

    void ShowPanel(GameObject target)
    {
        welcomePanel?.SetActive(false);
        mainMenuPanel?.SetActive(false);
        checkInPanel?.SetActive(false);
        recommendationPanel?.SetActive(false);
        if (target != null) target.SetActive(true);
    }
}
