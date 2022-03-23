using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Photon.Pun;

public class GameManageScript : MonoBehaviour
{
    private bool gameHasEnded;
    public GameObject gameOverPanelRef;
    public PhotonView _pview;

    public static GameManageScript instance;

    private void Awake()
    {
        instance = this;
    }

    //public event Action onCoinCollection;

   

   
    //public void CoinCollected()
    //{
    //    if(onCoinCollection!=null)
    //    {
    //        onCoinCollection();
    //    }
    //}

    public void LevelCompleted()
    {
        gameOverPanelRef.SetActive(true);
    }
}
