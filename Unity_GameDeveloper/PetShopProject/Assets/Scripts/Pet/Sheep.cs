using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : PetBase
{
    public override void PetSound()
    {
        base.PetSound();
        Debug.Log("Mée");
    }
}
