using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    private int teamNum;
    public List<int>[] TriggerBulletID;
    private int maxTeamID;
    private int maxBall;
    [HideInInspector]
    public int[] bearScore;

    private void Start()
    {
        teamNum = TeamPointSystem.Instance.teams.Count;
        TriggerBulletID = new List<int>[teamNum];
        bearScore = new int[teamNum];
        for (int i = 0; i < TriggerBulletID.Length; i++)
        {
            TriggerBulletID[i] = new List<int>();
        }
    }
    private void Update()
    {
        var teams = TeamPointSystem.Instance.teams;
    
        if (TriggerBulletID.Length>0)
        {
            maxTeamID = -1;
            maxBall = 0;
            for(int i=0 ; i<TriggerBulletID.Length ; i++)
            {
                //Debug.Log(TriggerBulletID[i]);
                if ( TriggerBulletID[i].Count > maxBall)//一方子弹数大于之前的最多子弹数
                {
                    maxBall = TriggerBulletID[i].Count;
                    maxTeamID = i;                          
                    
                }
                
            }
            for(int i=0;i<bearScore.Length;i++)
            {
                if (i == maxTeamID)
                    bearScore[i] = 1;
                else
                    bearScore[i] = 0;
            }

        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletLogic>())
        {
           // Debug.Log(TriggerBulletID[other.GetComponent<BulletLogic>().BulletID - 1]);
            TriggerBulletID[other.GetComponent<BulletLogic>().BulletID-1].Add(other.GetComponent<BulletLogic>().BulletID); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BulletLogic>())
        {
            TriggerBulletID[other.GetComponent<BulletLogic>().BulletID-1].Remove(other.GetComponent<BulletLogic>().BulletID);
        }
    }
}
