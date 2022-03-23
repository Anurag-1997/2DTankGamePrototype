using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public List<GameObject> pooledObjects = new List<GameObject>();
    public int poolSize;
    public GameObject prefab;
    public static ObjectPooler instance1;

    private void Awake()
    {
        instance1 = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<poolSize;i++)
        {
            GameObject temp1 = Instantiate(prefab);
            pooledObjects.Add(temp1);
            temp1.SetActive(false);
            
        }
    }

    public GameObject getPooledObjects()
    {
        for(int i=0;i<pooledObjects.Count;i++)
        {
            GameObject temp = pooledObjects[i];
            if(!temp.activeInHierarchy)
            {
                return temp;
            }
           
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
