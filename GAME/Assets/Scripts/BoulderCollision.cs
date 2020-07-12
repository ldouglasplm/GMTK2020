using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderCollision : MonoBehaviour
{

    public float MoveSpeed = 3.0f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Boulder") == true || collision.gameObject.tag.Equals("FinishedBoulder") == true)
        {
            Rigidbody myRigidbody = this.GetComponent<Rigidbody>();
            myRigidbody.isKinematic = false;

            if (gameObject.tag.Equals("1 Point") == true && gameObject.tag != ("collided"))
            {
                ScoreManager.score = ScoreManager.score + 1 * 13;
            }
            
            if (gameObject.tag.Equals("2 Point") == true && gameObject.tag != ("collided"))
            {
                ScoreManager.score = ScoreManager.score + 2 * 13;
            }

            if (gameObject.tag.Equals("3 Point") == true && gameObject.tag != ("collided"))
            {
                ScoreManager.score = ScoreManager.score + 3 * 13;
            }

            if (gameObject.tag.Equals("50 Point") == true && gameObject.tag != ("collided"))
            {
                ScoreManager.score = ScoreManager.score + 50 * 13;
            }

            myRigidbody.tag = "collided";

        }



    }

}
