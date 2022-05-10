using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //Variable to control the speed of rotation
    public float rotationSpeed;

    public bool rotateStatus = true;

    //Rotate object function
    public void RotateObject()
    {
        //When button is pressed make true if false
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else //If true make false
        {
            rotateStatus = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate planet around z axis if rotate status = true
        //(multiply by Time.deltaTime to make sure it rotates at the same speed reguardless of frame rate)
        if (rotateStatus == true)
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
        }
    }
}
