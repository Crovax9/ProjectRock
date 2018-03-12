using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeRotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.transform.Rotate(Vector3.forward, 10.0f);
    }
}
