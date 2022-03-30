using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Text teamScore1;
    public Text teamScore2;

    public void UpdateScore1(int score)
    {
        teamScore1.text = "" + score;
    }
    public void UpdateScore2(int score)
    {
        teamScore2.text = "" + score;
    }
}
