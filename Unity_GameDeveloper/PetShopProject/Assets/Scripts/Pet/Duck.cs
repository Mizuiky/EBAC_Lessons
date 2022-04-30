using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : PetBase
{
    public override void PetSound()
    {
        base.PetSound();
        Debug.Log("Quack");
    }
}
