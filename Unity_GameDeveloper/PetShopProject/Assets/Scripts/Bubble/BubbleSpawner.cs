using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BubbleSpawner : MonoBehaviour
{
    public List<Transform> positions;

    #region Private Fields

    private PoolManager _poolManager;

    private GraphicRaycaster _raycaster;

    private PointerEventData _pointerEventData;

    private EventSystem _eventSystem;

    #endregion 

    public void Start()
    {
        _raycaster = FindObjectOfType<GraphicRaycaster>();

        _eventSystem = GetComponent<EventSystem>();

        _poolManager = FindObjectOfType<PoolManager>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(0) && (Time.timeScale == 1f))
        {       
            if(CanSpawn(Input.mousePosition))
            {
                SpawnBubble();
            }          
        }
    }
    public void SpawnBubble()
    {
        var bubbles = _poolManager.GetPoolledObjects();

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

    private bool CanSpawn(Vector3 mousePosition)
    {
        //Code to check if the clicking is in a layer different from FoodView to spawn the bubbles

        //Set up the new Pointer Event
        _pointerEventData = new PointerEventData(_eventSystem);

        //Set the Pointer Event Position to that of the mouse position
        _pointerEventData.position = mousePosition;

        //Create a list of Raycast Results
        List<RaycastResult> results = new List<RaycastResult>();

        //Raycast using the Graphics Raycaster and mouse click position
        _raycaster.Raycast(_pointerEventData, results);

        //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
        foreach (RaycastResult result in results)
        {
            if (result.gameObject.CompareTag("FoodView"))
            {
                return false;
            }
        }

        return true;
    }
}
