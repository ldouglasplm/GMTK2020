using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPosition : MonoBehaviour
{
    [Header("Thing to rotate around")]
    public GameObject Turret;

    [Header("The axis by which it will rotate around")]
    public Vector3 axis;

    [Header("Angle covered per update")]
    public float angle; //or the speed of rotation.

    // Update is called once per frame
    void Update()
    {
        //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
        if (Input.GetKey("a"))
        {
            transform.RotateAround(Turret.transform.position, axis, angle*-1);
        }

        //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
        if (Input.GetKey("d"))
        {
            transform.RotateAround(Turret.transform.position, axis, angle);
        }
    }
}