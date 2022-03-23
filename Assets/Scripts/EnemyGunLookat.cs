using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunLookat : MonoBehaviour
{
    
    public Transform playerRef;
    public GameObject enemyBulletPrefab;
    public GameObject enemyFirePos;
    GameObject tempEnemyBullet;
    Vector3 dirEnemyToPlayer;
    public float enemyBulletForce;


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("EnemyFire", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        dirEnemyToPlayer = playerRef.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up,dirEnemyToPlayer);
        
        
        
    }
    private void FixedUpdate()
    {
        
    }

    public void EnemyFire()
    {
        tempEnemyBullet = ObjectPoolerWithQ.instance.GetFromPool("EnemyBullets", enemyFirePos.transform.position);
        //tempEnemyBullet = Instantiate(enemyBulletPrefab, enemyFirePos.transform);
        tempEnemyBullet.GetComponent<Rigidbody2D>().velocity = dirEnemyToPlayer * enemyBulletForce * Time.deltaTime;
        

    }
}
