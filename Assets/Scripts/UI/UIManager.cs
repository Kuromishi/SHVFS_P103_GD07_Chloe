using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject[] team;
    private int teamNum;

    private void Start()
    {
        teamNum = TeamPointSystem.Instance.teams.Count;
       
    }
    private void Update()
    {
        
    }
    //public void UpdateScore(int score)
    //{
    //    teamScore.text = "" + score;
    //}
}
