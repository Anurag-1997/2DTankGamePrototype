using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class InstantiateCoins : MonoBehaviour
{
    public GameObject instcoin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateCoinFn", 1, 1f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void InstantiateCoinFn()
    {
        //OBJECT POOLER WITH LIST 
        //GameObject tempCoins = ObjectPooler.instance1.getPooledObjects();
        //tempCoins.SetActive(true);
        //tempCoins.transform.position = new Vector3(Random.Range(-20, 20), Random.Range(-10, 10), 0);
        PhotonNetwork.Instantiate(instcoin.name, new Vector3(Random.Range(-20, 20), Random.Range(-10, 10), 0), Quaternion.identity);

        //OBJECT POOLER WITH QUEUE)
        //ObjectPoolerWithQ.instance.GetFromPool("coins", new Vector3(Random.Range(-20, 20), Random.Range(-10, 10), 0));

    }
}
