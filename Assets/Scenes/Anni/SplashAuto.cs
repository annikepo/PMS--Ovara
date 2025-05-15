
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashAuto : MonoBehaviour
{
    public GameObject splashPanel;
    public float flashDuration = 1.5f;

    void Start()
    {
        if (splashPanel != null)
            Invoke(nameof(LoadMenu), flashDuration);
        else
            Debug.LogWarning("Splash Panel not assigned!");
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("Menu Scene"); // Make sure this name is correct
    }
}
