using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset; // Define the offset in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the offset if needed
        offset = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new camera position based on the plane's position and the offset
        Vector3 newPosition = plane.transform.position + offset;
        
        // Apply the new camera position
        transform.position = newPosition;
    }
}
