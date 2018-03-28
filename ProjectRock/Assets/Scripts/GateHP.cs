using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHP : MonoBehaviour
{
    static float hp = 1000;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        hp -= rb.velocity.sqrMagnitude * 0.01f;
        Debug.Log(hp);
        if (hp > 0)
        {
            other.transform.position = new Vector3(2052, 512, 135);
        }
        else
        {
            this.GetComponent<MeshSplit>().enabled = true;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}