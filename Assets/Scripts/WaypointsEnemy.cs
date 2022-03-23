using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsEnemy : MonoBehaviour
{
    public static WaypointsEnemy instance;
    public Transform[] waypoints;
    public float minDistance = 0.2f;
    public GameObject target;

    public Transform initialWayPoint;
    public int lastIndex;
    public int index = 0;

    public float enemyTankSpeed = 5f;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        initialWayPoint = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        if(target!=null)
        {
            wayPointMover();
        }
        
        

    }

    public void wayPointMover()
    {
        float distance = Vector3.Distance(target.transform.position, initialWayPoint.position);
        if (distance <= minDistance)
        {
            index++;
            if (index > lastIndex)
            {
                index = 0;
            }
            initialWayPoint = waypoints[index];
        }
        target.transform.position = Vector3.MoveTowards(target.transform.position, initialWayPoint.position, enemyTankSpeed * Time.deltaTime);
        target.transform.up = target.transform.position - initialWayPoint.position;
    }
        
    
}
