using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // The object to be pooled
    public int poolSize = 10; // The initial pool size

    private List<GameObject> pooledObjects; // List to store the pooled objects

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        // Check for an inactive object in the pool
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        // If there are no inactive objects, create a new one
        GameObject obj = Instantiate(prefab);
        pooledObjects.Add(obj);
        return obj;
    }
}