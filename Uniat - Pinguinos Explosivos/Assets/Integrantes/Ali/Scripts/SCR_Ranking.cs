using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Ranking : MonoBehaviour {

    public GameObject[] players;
    SCR_PlayerTempStats[] myStats;
    List<SCR_PlayerTempStats> mySortingList;
    void Start()
    {
        
    }

    IEnumerator CheckPositions()
    {
        for(int i =0; i<7;i++)
        {
            myStats[i] = players[i].GetComponent<SCR_PlayerTempStats>();
            myStats[i].distanceToNext = Vector3.Distance(players[i].transform.position, myStats[i].nextTarget.transform.position);
            mySortingList.Add(myStats[i]);
            
        }
        mySortingList.Sort(SortByVar);
        

        yield return new WaitForSeconds(0.1f);

        StartCoroutine(CheckPositions());
    }

    public int SortByVar(SCR_PlayerTempStats a, SCR_PlayerTempStats b)
    {
        return a.distanceToNext.CompareTo(b.distanceToNext);
    }




}
