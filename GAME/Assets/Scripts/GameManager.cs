using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int boulderRolls = 0;
    public GameObject boulder;
    public GameObject currentBoulder;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(boulder);
    }

    // Update is called once per frame
    void Update()
    {
        if ((StartingPosition.gameStart == true && BoulderManager.boulderTooSlowTime > 3) || Input.GetKey("f"))
        {
            currentBoulder = GameObject.FindWithTag("Boulder");

            StartingPosition.gameStart = false;
        }
    }
}
