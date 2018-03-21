using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Ranking : MonoBehaviour {

    public GameObject[] players;
    public GameObject[] checkPoint;
    SCR_PlayerTempStats[] myStats;
    void Start()
    {
        
    }

    IEnumerator CheckPositions()
    {
        for(int i =0; i<7;i++)
        {
            myStats[i] = players[i].GetComponent<SCR_PlayerTempStats>();

            
        }


        yield return new WaitForSeconds(0.1f);

        StartCoroutine(CheckPositions());
    }




}
