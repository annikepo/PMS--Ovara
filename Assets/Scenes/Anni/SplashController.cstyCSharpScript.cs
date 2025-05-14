
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public AudioSource voiceAudio;
    public AudioSource musicAudio;

    void Start()
    {
        voiceAudio.Play();
        musicAudio.Play();

        // Automatically load next scene after voice ends
        StartCoroutine(WaitForVoiceToFinish());
    }

    IEnumerator WaitForVoiceToFinish()
    {
        // Wait until voice is done
        yield return new WaitForSeconds(voiceAudio.clip.length);

        // Optional: Fade out music here

        // Then load the next scene (menu)
        SceneManager.LoadScene("MenuScene"); // Or use scene index, like 1
    }
}
