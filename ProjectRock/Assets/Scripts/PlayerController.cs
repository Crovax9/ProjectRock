using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 270.0f;
    float CameraRotationX = 0.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        CameraRotationX = Input.GetAxis("Mouse X") * 10.0f;

        this.transform.Rotate(Vector3.up, CameraRotationX);
    }

    private void FixedUpdate()
    {
        Vector3 movement;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement = this.transform.forward;
            rb.AddForce(movement * speed, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movement = this.transform.forward;
            rb.AddForce(movement * -speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = this.transform.right;
            rb.AddForce(movement * -speed);
            Debug.Log(movement);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = this.transform.right;
            rb.AddForce(movement * speed);
        }
    }
}
