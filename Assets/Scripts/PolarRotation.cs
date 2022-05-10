using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarRotation : RotateAroundPoint
{
    // Update is called once per frame
    void Update()
    {
        //Rotate object around point on Z axis once rotate status = true
        //(multiply by Time.deltaTime to make sure it rotates at the same speed reguardless of frame rate)
        if (rotateStatus == true)
        {
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
        }

    }
}
