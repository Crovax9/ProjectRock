using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private void Start()
    {
        Invoke("PositionReset", 5.0f);
    }


    void PositionReset()
    {
        if (this.transform.position.y < 0)
        {
            this.transform.position = new Vector3(2052, 512, 135);
        }
    }
}