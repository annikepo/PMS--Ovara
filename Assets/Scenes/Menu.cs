
using UnityEngine;

public class MenuStartup : MonoBehaviour
{
    public GameObject menuCanvas;

    void Start()
    {
        if (menuCanvas != null)
            menuCanvas.SetActive(true);
    }
}
