using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PUNSpawner : MonoBehaviour
{
    public List<Transform> spawnerPositions;
    public GameObject playerPrefab;
    private void Start()
    {
        Transform randomSpawnPosition = spawnerPositions[Random.Range(0, spawnerPositions.Count)];
        PhotonNetwork.Instantiate(playerPrefab.name, randomSpawnPosition.position, Quaternion.identity);
        
    }
}
