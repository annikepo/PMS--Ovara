
using UnityEngine;

public class MenuFlowController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject checkInPanel;
    public GameObject recommendationPanel;

    public void GoToCheckIn()
    {
        mainMenuPanel.SetActive(false);
        checkInPanel.SetActive(true);
    }

    public void GoToRecommendations()
    {
        checkInPanel.SetActive(false);
        recommendationPanel.SetActive(true);
    }
}
