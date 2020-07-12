using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BoulderManager : MonoBehaviour
{
    public static float boulderSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody myRigidbody = this.GetComponent<Rigidbody>();
        //Debug.Log(myRigidbody.velocity.magnitude);
        boulderSpeed = myRigidbody.velocity.magnitude;
    }
}
