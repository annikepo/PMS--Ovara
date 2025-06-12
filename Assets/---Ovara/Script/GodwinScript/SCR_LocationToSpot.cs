using UnityEngine;

public class SCR_LocationToSpot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sets the GameObject's position to Spot 1 location
    /// </summary>
    public void SetSpot1()
    {
        transform.position = new Vector3(-15.2f,3.0f,14.7f);
    }

    /// <summary>
    /// Sets the GameObject's position to Spot 2 location
    /// </summary>
    public void SetSpot2()
    {
        transform.position = new Vector3(10.9f,4.1f,-2.6f); // You can change these coordinates as needed
    }

    /// <summary>
    /// Sets the GameObject's position to Spot 3 location
    /// </summary>
    public void SetSpot3()
    {
        transform.position = new Vector3(32.8f,3.0f,17.9f); // You can change these coordinates as needed
    }
}
