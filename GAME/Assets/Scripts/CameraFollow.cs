using UnityEngine;
using System.Collections;
using System.Security.Cryptography;
using System.Threading;
using System.Collections.Specialized;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Transform target;

    // Use this for initialization

    void Start()
    {
        
    }

    void Update()
    {
        player = GameObject.FindWithTag("Boulder");
        target = player.transform;

        if (StartingPosition.gameStart == false)
        {
            //transform.position = new Vector3 (0f, 53f, 0f);
            transform.LookAt(target);
        }

        if (StartingPosition.gameStart == true)
        {
            //transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, target.transform.position.z - target.transform.position.z - target.transform.position.z);
            transform.LookAt(target);
        }

    }
}