using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour, IPet
{
    #region Properties
    public Type Type 
    { 
        get 
        { 
            return type; 
        }
        set
        {
            type = value;
        }
    }

    public Status Status
    { 
        get 
        { 
            return status; 
        }
        set
        {
            status = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public int Hungry
    {
        get
        {
            return hungry;
        }
        set
        {
            hungry = value;
        }
    }

    #endregion

    #region Private Fields

    private Type type;

    private Status status;

    private int health;

    private int hungry;

    #endregion

    #region Public Fields

    public GameObject model;

    #endregion

    public void SetAttributes(Type type, Status status, int health, int hungry)
    {
        Type = type;
        Status = status;
        Health = health;
        Hungry = hungry;
    }
}
public enum Type
{
    Cat,
    Sheep,
    Duck
}

public enum Status
{
    Happy,
    Sad,
    Sleepy
}
