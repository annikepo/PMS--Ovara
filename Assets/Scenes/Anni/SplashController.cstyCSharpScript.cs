
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public AudioSource voiceAudio;
    public AudioSource musicAudio;
    public string nextSceneName = "MenuScene";

    void Start()
    {
        if (voiceAudio != null)
        {
            StartCoroutine(WaitForVoiceAndLoadScene());
        }
        else
        {
            Debug.LogWarning("Voice Audio is not assigned. Skipping to menu...");
            LoadNextScene();
        }
    }

    private System.Collections.IEnumerator WaitForVoiceAndLoadScene()
    {
        // Wait until voice audio is done
        yield return new WaitWhile(() => voiceAudio.isPlaying);
        yield return new WaitForSeconds(3f); // small delay for polish
        LoadNextScene();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
