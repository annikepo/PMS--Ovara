using UnityEngine;

public class Scr_SetLocationToSpot3 : MonoBehaviour
{
    [SerializeField] private bool isSpot3Location = false;
    private Vector3 spot3Position = new Vector3(5.23374939f, 3.12000012f, 13.9400005f);
    private bool hasBeenSet = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }    // Update is called once per frame
    void Update()
    {
        // Check if we should set the location and haven't already done so
        if (isSpot3Location && !hasBeenSet)
        {
            Spot3Location();
            hasBeenSet = true;
        }
        
        // Reset the flag when isSpot3Location is set to false
        if (!isSpot3Location)
        {
            hasBeenSet = false;
        }
    }

    /// <summary>
    /// Sets the GameObject's position to the predefined Spot3 location
    /// </summary>
    public void Spot3Location()
    {
        transform.position = spot3Position;
    }
}
