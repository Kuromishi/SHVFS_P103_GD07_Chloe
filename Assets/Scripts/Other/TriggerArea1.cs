using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ScoreTriggerArea : MonoBehaviour
{
   // public int TeamID;
   // //Score changes...拥有的数
   // public int Score;
   // //Update our score, 每帧应该增加的数
   //public int TickPoints;
   // //public float CubeTickPoints;
   // //public float SphereTickPoints;
   // //public float CylinderTickPoints;
   // //How often do we receive points?
   // public float TickRate;
   // //Changes.. 计时器
   // public float tickTimer=0;
   // public int TriggerAreaID = 0;
   // //public float CubetickTimer;
   // //public float SpheretickTimer;
   // //public float CylindertickTimer;

   // public List<int> TriggerBearID = new List<int>();
    
    

   // // Start is called before the first frame update
   // void Start()
   // {
        
   //     //Score = 0;
   //     var zones = TeamPointSystem.instance.zones; 
   //     zones.Add(this); TriggerAreaID = zones.IndexOf(this); 
   //     Debug.Log(TriggerAreaID);
   // }

   // // Update is called once per frame
   // void Update()
   // {

   //     tickTimer += Time.deltaTime;
   //      bool IsSameID=true;
   //     if (tickTimer < TickRate) return;
        

   //     if (TriggerBearID.Count != 0)
   //     {
   //         var CurMemID = TriggerBearID[0];
   //         foreach (var TheBearID in TriggerBearID) //每一个成员
   //         {
   //             if (TheBearID != CurMemID)
   //             {
   //                 IsSameID = false;
   //                 //tickTimer = 0;
   //             }
   //         }
   //         var teams = TeamPointSystem.Instance.teams;
   //         if (IsSameID && TriggerBearID.Count > TeamPointSystem.instance.minNumOfTeam)
   //         {
   //             for (var i = 0; i < teams.Count; i++)
   //             {
   //                 if (teams[i].ID == CurMemID)
   //                 {
   //                     teams[i].TeamScore += TickPoints;
                       
   //                     Debug.Log("Team" + $"{teams[i].ID}" + "'s score=" + $"{teams[i].TeamScore}");
   //                 }
   //             }
   //         }
   //         tickTimer = 0;
   //     }
        
    //}
    //public void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.GetComponent<TriggerArea>()!=null)
    //    {
    //        //Debug.Log("enter");
    //        //other.GetComponent<TriggerArea>().ChangeMember(TeamID, true);
    //        TriggerBearID.Add(GetComponent<TriggerArea1>().TeamID);
    //    }
    //}
    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.GetComponent<TriggerArea>() != null)
    //    {
    //       // other.GetComponent<TriggerArea>().ChangeMember(TeamID, false);
    //        TriggerBearID.Remove(GetComponent<TriggerArea1>().TeamID);
    //    }
    //}

    //public void OnDestroy()
    //{
        
    //}



    //public void OnTriggerStay(Collider other)
    //{
    //    //if (other.gameObject.GetComponent<Cube>() == null) return; 全return掉了！

    //    if (other.gameObject.GetComponent<Cube>() != null)
    //    {
    //        CubetickTimer += Time.deltaTime; //如果没有，上面直接返回

    //        if (CubetickTimer < TickRate) return;

    //        Score += CubeTickPoints; //每次经过一段时间（tickrate），就会加一次分数，然后归零// bug是出区域不会归零
    //        CubetickTimer = 0;
    //        TeamPointSystem.Instance.ScorePoints();
    //        Debug.Log($"{Score}");
    //    }


    //   //if (other.gameObject.GetComponent<Spheres>() == null) return;
    //    if (other.gameObject.GetComponent<Spheres>() != null)
    //    {
    //        SpheretickTimer += Time.deltaTime;


    //        if (SpheretickTimer < TickRate) return;

    //        Score += SphereTickPoints;
    //        SpheretickTimer = 0;
    //        // TeamPointSystem.Instance.ScorePoints();
    //        Debug.Log($"{Score}");
    //    }



    //   // if (other.gameObject.GetComponent<Cylinder>() == null) return;
    //    if (other.gameObject.GetComponent<Cylinder>() != null)
    //    {
    //        CylindertickTimer += Time.deltaTime;


    //        if (CylindertickTimer < TickRate) return;

    //        Score += CylinderTickPoints;
    //        CylindertickTimer = 0;
    //        TeamPointSystem.Instance.ScorePoints();
    //        Debug.Log($"{Score}");
    //    }

    //}

}
