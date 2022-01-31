/*
 * Zechariah Burrus
 * Assignment 2
 * Adds a rotation to the Prop so it looks more realistic
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
