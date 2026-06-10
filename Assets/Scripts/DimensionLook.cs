using UnityEngine;

public class DimensionLook : MonoBehaviour
{
    Camera cam;
    public int currentDimension;
    private string[] dimensions =
        {
            "All",
            "Red",
            "Green",
            "Blue"
        };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
        currentDimension = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (currentDimension < dimensions.Length - 1)
                currentDimension++;
            else currentDimension = 0;
            SwitchDimension(dimensions[currentDimension]);
        }
    }

    void SwitchDimension(string dimension)
    {
        if(dimension == "All")
        {
            cam.cullingMask |= LayerMask.GetMask(dimensions[1], dimensions[2], dimensions[3]); // ADDS ALL DIMENSIONS
        }
        else
        {
            cam.cullingMask &= ~LayerMask.GetMask(dimensions[1], dimensions[2], dimensions[3]); // REMOVES ONLY THESE LAYERS DUE TO ~
                                                                                                // Without ~ It would remove all other layers except, red, green, blue
            cam.cullingMask |= 1 << LayerMask.NameToLayer(dimension);                           // ADDS CURRENT DIMENSION
        }
        
    }
}
