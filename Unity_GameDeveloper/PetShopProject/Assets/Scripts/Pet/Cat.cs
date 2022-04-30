using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : PetBase
{
    public override void PetSound()
    {
        base.PetSound();
        Debug.Log("MIAU");
    }
}
