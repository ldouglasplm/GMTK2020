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
        //UnityEngine.Debug.Log(Time.time - StartingPosition.gameStartTime); 
        // IF BOULDER OBJECT HAS LOW VELOCITY THEN GET RID OF IT AND SPAWN A NEW ONE
        if (BoulderManager.boulderSpeed < 1f && Time.time - StartingPosition.gameStartTime > 3) // NEED TO CHANGE TO BE 3 SOLID SECONDS OF BEING BELOW VELOCITY THRESHOLD
        {
            currentBoulder = GameObject.FindWithTag("Boulder");
            Destroy(currentBoulder);
        }
    }
}
