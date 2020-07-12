using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class BoulderManager : MonoBehaviour
{
    public static float boulderSpeed;

    public static bool boulderTooSlow;
    public static float boulderTooSlowTime;

    // Start is called before the first frame update
    void Start()
    {
        boulderTooSlow = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody myRigidbody = this.GetComponent<Rigidbody>();
        //Debug.Log(myRigidbody.velocity.magnitude);
        boulderSpeed = myRigidbody.velocity.magnitude;

        if (boulderSpeed < 1f && StartingPosition.gameStart == true)
        {
            boulderTooSlow = true;
            boulderTooSlowTime = boulderTooSlowTime + Time.deltaTime;
        }

        if (boulderSpeed > 1f && StartingPosition.gameStart == true)
        {
            boulderTooSlow = false;
            boulderTooSlowTime = 0f;
        }

        UnityEngine.Debug.Log(boulderTooSlowTime);
    }
}
