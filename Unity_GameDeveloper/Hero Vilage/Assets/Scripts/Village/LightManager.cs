using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LightManager : MonoBehaviour
{
    #region Public Fields

    [Header("References")]
    public Color off;
    public Color[] availableColors;
    public Light[] lights;
    public GameObject cam;
    #endregion

    private int index;

    void Start()
    {
        cam.GetComponent<CinemachineVirtualCamera>().enabled = true;
        ResetLight();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeColor();
        }
    }

    public void changeColor()
    {
        var currentColor = GetColor();

        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].color = currentColor;
        }

        index++;
    }

    public Color GetColor()
    {
        return availableColors[index % availableColors.Length];
    }

    public void ResetLight()
    {
        index = 0;

        foreach (Light light in lights)
        {
            light.color = off;
        }
    }
}

