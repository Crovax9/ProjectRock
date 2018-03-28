using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTExplosion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            this.transform.GetComponentInChildren<MeshSplit>().enabled = true;
            other.transform.SendMessage("Boom");
        }
    }
}