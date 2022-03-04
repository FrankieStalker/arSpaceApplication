using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{

    //Variable to control the speed of rotation
    public float rotationSpeed;
    //Variable to hold object to rotate around
    public GameObject pivotObject;
    bool rotateStatus = false;

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
        if(rotateStatus == true)
        {
            //Rotate object around point once rotate status = true
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
        }
        
    }
}
