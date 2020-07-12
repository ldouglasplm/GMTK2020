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
            
            if (gameObject.tag.Equals("1 Point") == true)
            {
                ScoreManager.score = ScoreManager.score + 1;
            }

            if (gameObject.tag.Equals("2 Point") == true)
            {
                ScoreManager.score = ScoreManager.score + 2;
            }

            if (gameObject.tag.Equals("3 Point") == true)
            {
                ScoreManager.score = ScoreManager.score + 3;
            }

        }

    }


}
