using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConnectToServer :MonoBehaviourPunCallbacks
{
    public GameObject canvasRef;
    public InputField createRoomName;
    public InputField joinRoomName;
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
        canvasRef.SetActive(true);
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoomName.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomName.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
