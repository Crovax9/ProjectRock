using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceZone : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * 20000.0f);
    }
}
