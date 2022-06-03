using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float speed;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float fowardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode swithKey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        fowardInput = Input.GetAxis("Vertical" + inputID);

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

        //Change the camera
        if (Input.GetKeyDown(swithKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
