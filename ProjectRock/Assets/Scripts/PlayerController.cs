using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 270.0f;
    float cameraRotationX = 0.0f;
    static bool controllerFlag = true;

    private Rigidbody rb;

    public static bool ControllerFlag
    {
        get
        {
            return controllerFlag;
        }
        set
        {
            controllerFlag = value;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    private void LateUpdate()
    {
        cameraRotationX = Input.GetAxis("Mouse X") * 10.0f;

        this.transform.Rotate(Vector3.up, cameraRotationX);
    }
    
    private void FixedUpdate()
    {
        Vector3 movement;
        if (ControllerFlag)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                movement = this.transform.forward;
                rb.AddForce(movement * speed, ForceMode.Force);
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                movement = this.transform.forward;
                rb.AddForce(movement * -speed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                movement = this.transform.right;
                rb.AddForce(movement * -speed);
                Debug.Log(movement);
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                movement = this.transform.right;
                rb.AddForce(movement * speed);
            }
        }

        Physics.IgnoreLayerCollision(9, 10);
    }

    void Boom()
    {
        Collider[] List = Physics.OverlapSphere(transform.position, 50f);

        foreach (Collider list in List)
        {
            Rigidbody rigid = list.gameObject.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddExplosionForce(50000.0f, this.transform.position, 10.0f, 3000.0f);
            }
        }
    }
}
