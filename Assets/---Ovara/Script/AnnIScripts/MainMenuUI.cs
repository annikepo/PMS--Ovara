
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        // Replace with your actual game scene name
        SceneManager.LoadScene("Level 2");
    }

    public void OpenSettings()
    {
        Debug.Log("Settings clicked.");
        // Add logic to show settings panel
    }

    public void OpenHelp()
    {
        Debug.Log("Help clicked.");
        // Add logic to show help panel
    }

    public void QuitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
