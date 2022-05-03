using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public List<Transform> positions;

    private PoolManager poolManager;

    public void Start()
    {
        poolManager = FindObjectOfType<PoolManager>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(0) && (Time.timeScale == 1f))
        {
            SpawnBubble();
        }
    }
    public void SpawnBubble()
    {
        var bubbles = poolManager.GetPoolledObjects();

        if(bubbles != null)
        {
            bubbles.transform.position = GetRandomPosition();

            bubbles.GetComponent<Bubble>().Activate();
        }    
    }

    private Vector3 GetRandomPosition()
    {
        var index = Random.Range(0, positions.Count - 1);

        return positions[index].position;
    }
}
