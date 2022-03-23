using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolerWithQ : MonoBehaviour
{
    public static ObjectPoolerWithQ instance;
    private void Awake()
    {
        instance = this;
    }
    [System.Serializable]
    public class Pool
    {
        public string poolName;
        public int poolSize;
        public GameObject poolPrefab;
    }
    public List<Pool> pooledObjects = new List<Pool>();
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool item in pooledObjects)
        {
            Queue<GameObject> objectsPooled = new Queue<GameObject>();
            for (int i = 0; i < item.poolSize; i++) 
            {
                GameObject temp = Instantiate(item.poolPrefab, this.transform);
                temp.SetActive(false);
                objectsPooled.Enqueue(temp);
            }
            poolDictionary.Add(item.poolName, objectsPooled);
        }
    }
    public GameObject GetFromPool(string poolName,Vector3 pos)
    {
        GameObject getObjfromQ = poolDictionary[poolName].Dequeue();
        getObjfromQ.SetActive(true);
        getObjfromQ.transform.position = pos;
        poolDictionary[poolName].Enqueue(getObjfromQ);

        return getObjfromQ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
