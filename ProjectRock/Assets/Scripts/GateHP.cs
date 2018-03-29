using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHP : MonoBehaviour
{
    [SerializeField]
    BoxCollider parentCollider;

    static float hp = 1000;
    
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        hp -= rb.velocity.sqrMagnitude;
        if (hp > 0)
        {
            PlayerController.ControllerFlag = false;
            StartCoroutine(ReSetPosition(other));
        }
        else
        {
            parentCollider.enabled = false;
            this.GetComponent<MeshSplit>().enabled = true;
        }
    }
    
    IEnumerator ReSetPosition(Collider other)
    {
        yield return new WaitForSeconds(3.0f);
        other.transform.position = new Vector3(2052, 512, 135);
        PlayerController.ControllerFlag = true;
    }
}