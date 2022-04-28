using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPet
{
    public Type Type { get; set; }
    public Status Status { get; set; }
    public int Health { get; set; }
    public int Hungry { get; set; }

    public void SetAttributes(Type type, Status status, int health, int hungry);
}
