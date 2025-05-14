
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject splashPanel;
    public GameObject mainPanel;
    public GameObject settingsPanel;
    public GameObject helpPanel;
    public GameObject quitPanel;

    void Start()
    {
        ShowPanel(splashPanel);
        Invoke("ShowMainPanel", 4f); // After splash
    }

    public void ShowMainPanel() => ShowPanel(mainPanel);
    public void ShowSettings() => ShowPanel(settingsPanel);
    public void ShowHelp() => ShowPanel(helpPanel);
    public void ShowQuit() => ShowPanel(quitPanel);

    void ShowPanel(GameObject panelToShow)
    {
        splashPanel.SetActive(false);
        mainPanel.SetActive(false);
        settingsPanel.SetActive(false);
        helpPanel.SetActive(false);
        quitPanel.SetActive(false);

        panelToShow.SetActive(true);
    }
}
