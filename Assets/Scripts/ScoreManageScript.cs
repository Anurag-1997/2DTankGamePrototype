using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class ScoreManageScript : MonoBehaviour
{
    public TMP_Text tmptxt;
    public int score = 0;
    public static ScoreManageScript instance1;
    public PhotonView pview;
    // Start is called before the first frame update
    void Start()
    {
        //GameManageScript.instance.onCoinCollection += ScoreUpdater;
        instance1 = this;
        pview = GetComponent<PhotonView>();

    }

    public void ScoreUpdater()
    {
        score += 10;
        tmptxt.text = "Score : " + score.ToString();
        
    }
}
