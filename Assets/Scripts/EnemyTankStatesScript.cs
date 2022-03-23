using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankStatesScript : MonoBehaviour
{
    //public GameObject targetEnemyTank;
    public GameObject player;
    public float enemyTankSpeed = 10f;
    

    private void Start()
    {
        
    }
    public enum TANKSTATES
    {
        IDLE,PATROL,ATTACK,DIE
    };
    public TANKSTATES ts;

    private void Update()
    {
        switch (ts)
        {
            case TANKSTATES.IDLE:
                break;
            case TANKSTATES.PATROL:
                WaypointsEnemy.instance.wayPointMover();
                break;
            case TANKSTATES.ATTACK:
                //transform.position= Vector3.MoveTowards(transform.position, player.transform.position, enemyTankSpeed * Time.deltaTime);
                //egla.EnemyFire();
                break;
            case TANKSTATES.DIE:
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            ts = TANKSTATES.ATTACK;
        }
    }
}
