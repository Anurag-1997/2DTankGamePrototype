using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Photon.Pun;

public class GameManageScript : MonoBehaviour
{
    private bool gameHasEnded;
    //public GameObject gameOverPanelRef;
    public PhotonView _pview;
    public Text winLoseText;

    public static GameManageScript instance;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if(ScoreManageScript.instance1.score>=100)
        {
            _pview.RPC("GetWinLoseText", RpcTarget.AllBuffered);
        }
    }
    [PunRPC]
    void GetWinLoseText()
    {
        if (_pview.IsMine)
        {
            winLoseText.text = "winner";
        }
        else
        {
            winLoseText.text = "Loser";
        }
    }

    //public event Action onCoinCollection;
    //public void CoinCollected()
    //{
    //    if(onCoinCollection!=null)
    //    {
    //        onCoinCollection();
    //    }
    //}
    
}
