using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class StartingPosition : MonoBehaviour
{
    [Header("Thing to rotate around")]
    public GameObject Turret;

    [Header("The axis by which it will rotate around")]
    public Vector3 axis;

    [Header("Angle covered per update")]
    public float angle; //or the speed of rotation.

    public static bool gameStart = false;
    public static float gameStartTime = 100000;

    void Start()
    {
        Turret = GameObject.Find("StartingPosition");
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == ("Boulder")) {
            //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
            if (Input.GetKey("a") && gameStart == false)
            {
                transform.RotateAround(Turret.transform.position, axis, angle * -1);
            }

            //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
            if (Input.GetKey("d") && gameStart == false)
            {
                transform.RotateAround(Turret.transform.position, axis, angle);
            }

            if (Input.GetKey("space") && gameStart == false)
            {
                Rigidbody boulderRigidbody = this.GetComponent<Rigidbody>();
                boulderRigidbody.isKinematic = false;
                gameStart = true;
                gameStartTime = Time.time;
            }
        }
    }
}