using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ScoreTriggerArea : MonoBehaviour
{
   // public int TeamID;
   // //Score changes...ӵ�е���
   // public int Score;
   // //Update our score, ÿ֡Ӧ�����ӵ���
   //public int TickPoints;
   // //public float CubeTickPoints;
   // //public float SphereTickPoints;
   // //public float CylinderTickPoints;
   // //How often do we receive points?
   // public float TickRate;
   // //Changes.. ��ʱ��
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
   //         foreach (var TheBearID in TriggerBearID) //ÿһ����Ա
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
    //    //if (other.gameObject.GetComponent<Cube>() == null) return; ȫreturn���ˣ�

    //    if (other.gameObject.GetComponent<Cube>() != null)
    //    {
    //        CubetickTimer += Time.deltaTime; //���û�У�����ֱ�ӷ���

    //        if (CubetickTimer < TickRate) return;

    //        Score += CubeTickPoints; //ÿ�ξ���һ��ʱ�䣨tickrate�����ͻ��һ�η�����Ȼ�����// bug�ǳ����򲻻����
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
