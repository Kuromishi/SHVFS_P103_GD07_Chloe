using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

    public class TeamPointSystem : Singleton<TeamPointSystem>
    {

        //Need a way to get all the team members when this thing is added to the scene
        //Need a way for team member to register DYNAMICALLY as THEY are added to the scene
        public List<Team> teams = new List<Team>();
        private Zone[] zones;
        //public int minNum=2;


    public override void Awake()
        {
            base.Awake();
            zones = FindObjectsOfType<Zone>();
            var scorerComponents = FindObjectsOfType<ScorerComponent>();

            foreach (var scorerComponent in scorerComponents) //每一个成员
            {
            //Without LINQ...
            var matchingTeamIndex = -1;
            for (var i = 0; i < teams.Count; i++) //第几队
            {
                if (teams[i].ID.Equals(scorerComponent.TeamID))
                {
                    matchingTeamIndex = i; //ID数 = i
                }
            }
            if (matchingTeamIndex < 0)
            {
                var team = new Team()//创建新的组
                {
                    ID = scorerComponent.TeamID,
                    Members = new List<ScorerComponent> { scorerComponent }
                };

                teams.Add(team);
            }
            else
            {
                if (teams[matchingTeamIndex].Members.Contains(scorerComponent)) return;

                teams[matchingTeamIndex].Members.Add(scorerComponent);
            }


            //With LINQ...
            //if (!teams.Any(team => team.ID.Equals(scorerComponent.TeamID)))
            //{
            //    var team = new Team()
            //    {
            //        ID = scorerComponent.TeamID,
            //        Members = new List<ScorerComponent> { scorerComponent }
            //    };

            //    teams.Add(team);
            //}
            //else
            //{
            //    var team = teams.FirstOrDefault(team => team.ID.Equals(scorerComponent.TeamID));

            //    if (team.Members.Contains(scorerComponent)) return;

            //    team.Members.Add(scorerComponent);
            //}
            }
        }
    private void Update()
    {
        CalculateScore();


    }
    public void CalculateScore()
    {
        int totalscore=0;
        for(int j = 0; j < teams.Count; j++)
        {
            for (int i = 0; i < zones.Length; i++)
            {
                totalscore += zones[i].bearScore[j];
            }
            teams[j].TeamScore = totalscore;
            Debug.Log("Team " + $"{teams[j].ID}" + "'s score=" + $"{teams[j].TeamScore}");
            totalscore = 0;
        }
    }
}
    
    [Serializable] 
    public class Team
    {
        public int ID;
        public List<ScorerComponent> Members;
        public int TeamScore;
    }


