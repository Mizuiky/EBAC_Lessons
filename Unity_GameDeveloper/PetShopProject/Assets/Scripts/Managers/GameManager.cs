using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        PauseTime(true);
    }
    public void PauseTime(bool pause)
    {

        Time.timeScale = pause ? 0 : 1;
    }
}
