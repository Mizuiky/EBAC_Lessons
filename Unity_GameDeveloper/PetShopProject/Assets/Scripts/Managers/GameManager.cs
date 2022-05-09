using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIController _uiController;

    void Start()
    {
        PauseTime(true);
    }
    public void PauseTime(bool pause)
    {
        Time.timeScale = pause ? 0 : 1;
    }
}
