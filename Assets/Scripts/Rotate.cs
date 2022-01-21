using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //Variable to control the speed of rotation
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        //Rotate planet around z axis (multiply by Time.deltaTime to make sure it rotates at the same speed reguardless of frame rate)
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}
