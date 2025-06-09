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
        transform.position = new Vector3(9.6f, 3.8f, 4.1f);
    }

    /// <summary>
    /// Sets the GameObject's position to Spot 2 location
    /// </summary>
    public void SetSpot2()
    {
        transform.position = new Vector3(-18.0f, 9.0f, -30.0f); // You can change these coordinates as needed
    }

    /// <summary>
    /// Sets the GameObject's position to Spot 3 location
    /// </summary>
    public void SetSpot3()
    {
        transform.position = new Vector3(5.0f, 4.1f, 13.9f); // You can change these coordinates as needed
    }
}
