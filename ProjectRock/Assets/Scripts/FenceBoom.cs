using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceBoom : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Sphere")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            this.transform.GetComponentInChildren<MeshSplit>().enabled = true;
        }
    }
}