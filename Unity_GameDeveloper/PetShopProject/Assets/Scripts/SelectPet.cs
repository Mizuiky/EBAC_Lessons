using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPet : MonoBehaviour
{
    #region Public Field

    public List<PetBase> pets;

    public HUD hud;

    #endregion

    #region Private Fields

    private PetBase _currentPet;

    #endregion

    void Start()
    {
        hud.Reset();
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            GetInput();
        }      
    }

    private void GetInput()
    {    
        var keys = System.Enum.GetValues(typeof(KeyCode));
                                 
        foreach(KeyCode key in keys)
        {
            if(Input.GetKey(key))
            {
                CheckKey(key);
            }
        }                          
    }

    //Checking which key was pressed, if a different one from A,S or D was pressed then a warning message will appear to the player
    private void CheckKey(KeyCode key)
    {
        switch(key)
        {
            case KeyCode.A:
                SelectCat();
                break;

            case KeyCode.S:
                SelectSheep();
                break;

            case KeyCode.D:
                SelectDuck();
                break;

            default:
                hud.SetWarningMessage();
                return;
        }

        hud.SetText(_currentPet);
    }
    public void SelectCat()
    {
        _currentPet = pets[0];
        _currentPet.PetSound();
        hud.SetHightight(_currentPet.data.hightlightPosition);
    }

    public void SelectSheep()
    {
        _currentPet = pets[1];
        _currentPet.PetSound();
        hud.SetHightight(_currentPet.data.hightlightPosition);
    }

    public void SelectDuck()
    {
        _currentPet = pets[2];
        _currentPet.PetSound();
        hud.SetHightight(_currentPet.data.hightlightPosition);
    }   
}
