using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    private float rotationSpeed = 40.0f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * speed);

        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
        transform.Rotate(Vector3.left, rotationSpeed * verticalInput * Time.deltaTime);
    }
}
