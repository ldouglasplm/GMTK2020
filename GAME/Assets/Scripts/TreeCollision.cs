using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    // Let the rigidbody take control and detect collisions.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Boulder") == true)
        {
            Rigidbody boolTreeRigid = this.GetComponent<Rigidbody>();
            boolTreeRigid.isKinematic = false;
        }
    }
}
