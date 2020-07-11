using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Boulder") == true)
        {
            Rigidbody myRigidbody = this.GetComponent<Rigidbody>();
            myRigidbody.isKinematic = false;
            Debug.Log(myRigidbody.velocity);
        }
    }

    void FixedUpdate()
    {
        // Makes this object move forward at X speed.
    }


}
