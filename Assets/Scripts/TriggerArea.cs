using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class TriggerArea : MonoBehaviour
{
    //public int TeamID;
    //Score changes...拥有的数
    //public int Score;
    //Update our score, 每帧应该增加的数
    public int TickPoints;

    //How often do we receive points?
    public float TickRate;
    //Changes.. 计时器
    public float tickTimer = 0;

    public List<int> TriggerBearID = new List<int>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tickTimer += Time.deltaTime;
        bool IsSameID = true;
        if (tickTimer < TickRate) return;


        if (TriggerBearID.Count != 0)
        {
            var CurMemID = TriggerBearID[0];
            foreach (var TheBearID in TriggerBearID) //每一个成员
            {
                //Debug.Log("Value:" + TheBearID);
                if (TheBearID != CurMemID)
                {
                    IsSameID = false;
               
                    //tickTimer = 0;
                }

            }
            var teams = TeamPointSystem.Instance.teams;
            
            if (IsSameID && TriggerBearID.Count >= TeamPointSystem.Instance.minNum )
            {
                for (var i = 0; i < teams.Count; i++)
                {
                    if (teams[i].ID == CurMemID)
                    {
                        teams[i].TeamScore += TickPoints;

                        Debug.Log("Team " + $"{teams[i].ID}" + "'s score=" + $"{teams[i].TeamScore}");
                    }
                }
            }
            tickTimer = 0;
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
       // Debug.Log("enter");
        if (other.GetComponent<ScorerComponent>()) 
        {
           
            TriggerBearID.Add(other.GetComponent<ScorerComponent>().TeamID); 
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.GetComponent<ScorerComponent>()) 
        {
            TriggerBearID.Remove(other.GetComponent<ScorerComponent>().TeamID);
        } 
    }

}
