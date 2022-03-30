using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    private int teamNum;
    public List<int>[] TriggerBulletID;
    private int maxTeamID;
    private int previousMaxTeamID;

    private void Awake()
    {
        teamNum = TeamPointSystem.Instance.teams.Count;
        TriggerBulletID = new List<int>[teamNum];
    }
    private void Update()
    {
        var teams = TeamPointSystem.Instance.teams;

        if (TriggerBulletID.Length>0)
        {
            maxTeamID = 0;
            previousMaxTeamID = 0;
            for(int i=1 ; i<TriggerBulletID.Length ; i++)
            {
                if (TriggerBulletID[i].Count > TriggerBulletID[maxTeamID].Count)//一类的子弹的数量大于另一类子弹的数量
                {
                    maxTeamID = i;
                    teams[i].TeamScore += 1;
                }

            }
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletLogic>())
        {
            TriggerBulletID[other.GetComponent<BulletLogic>().BulletID].Add(other.GetComponent<BulletLogic>().BulletID); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BulletLogic>())
        {
            TriggerBulletID[other.GetComponent<BulletLogic>().BulletID].Remove(other.GetComponent<BulletLogic>().BulletID);
        }
    }
}
