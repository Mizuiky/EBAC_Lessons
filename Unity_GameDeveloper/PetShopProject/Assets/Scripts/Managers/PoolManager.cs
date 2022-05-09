using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject prefab;

    public int amount;

    private List<GameObject> _poolledObjects;

    public void Start()
    {
        InitPool();    
    }

    private void InitPool()
    {
        _poolledObjects = new List<GameObject>();

        for(int i = 0; i < amount; i++)
        {
            var obj = Instantiate(prefab, this.transform);
            obj.GetComponent<IActivate>().Deactivate();
            _poolledObjects.Add(obj);
        }
    }

    public GameObject GetPoolledObjects()
    {
        foreach(GameObject obj in _poolledObjects)
        {
            if(!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }

}
