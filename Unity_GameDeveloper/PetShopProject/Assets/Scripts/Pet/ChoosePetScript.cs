using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePetScript : MonoBehaviour
{
    #region Public Field

    public List<Pet> pets;

    public HUD hud;

    #endregion

    #region Private Fields

    private Pet pet;

    #endregion


    void Start()
    {
        hud.Reset();
        pet = new Pet();
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

        hud.SetText(pet);
    }
    public void SelectCat()
    {
        pet.SetAttributes(Type.Cat, Status.Happy, 10, 8);
        hud.SetHightight(HighPoint.left);
    }

    public void SelectSheep()
    {
        pet.SetAttributes(Type.Sheep, Status.Sad, 4, 3);
        hud.SetHightight(HighPoint.Middle);
    }

    public void SelectDuck()
    {
        pet.SetAttributes(Type.Duck, Status.Sleepy, 8, 6);
        hud.SetHightight(HighPoint.Right);
    }   
}
