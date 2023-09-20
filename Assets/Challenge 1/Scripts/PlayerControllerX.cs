using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 25.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called at a fixed time interval
    void FixedUpdate()
    {
        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Tilt the plane up/down based on up/down arrow keys
        float rotationAmount = rotationSpeed * Time.deltaTime * verticalInput;
        transform.Rotate(Vector3.right * rotationAmount);
    }
}


