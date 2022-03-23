using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManageScript : MonoBehaviour
{
    public TMP_Text tmptxt;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //GameManageScript.instance.onCoinCollection += ScoreUpdater;
    }

    void ScoreUpdater()
    {
        score += 10;
        tmptxt.text = "Score : " + score.ToString();
        if (score >= 100)
        {
            //FindObjectOfType<GameManageScript>().LevelCompleted();
            GameManageScript.instance.LevelCompleted();
        }

    }
}
