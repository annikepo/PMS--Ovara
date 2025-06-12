using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_NavToForest : MonoBehaviour
{
    [SerializeField] private string forestSceneName = "Ovara_03_ForestScene";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// Loads the forest scene when called.
    /// This method can be assigned to a button's onClick event in the Unity Inspector.
    /// </summary>
    public void LoadForestScene()
    {
        Debug.Log("Loading forest scene: " + forestSceneName);
        SceneManager.LoadScene(forestSceneName);
    }
}
