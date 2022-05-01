using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private List<GameObject> poolledObjects;

    public GameObject prefab;

    public int amount;

    public void Start()
    {
        InitPool();    
    }

    private void InitPool()
    {
        poolledObjects = new List<GameObject>();

        for(int i = 0; i < amount; i++)
        {
            var obj = Instantiate(prefab, this.transform);
            obj.GetComponent<IActivate>().Deactivate();
            poolledObjects.Add(obj);
        }
    }

    public GameObject GetPoolledObjects()
    {
        foreach(GameObject obj in poolledObjects)
        {
            if(!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }

}
