using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetBase : MonoBehaviour, IPet
{
    #region Properties
    public Type Type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }

    public Status Status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    public int Hungry
    {
        get
        {
            return _hungry;
        }
        set
        {
            _hungry = value;
        }
    }

    #endregion

    #region Private Fields

    private Type _type;

    private Status _status;

    private int _health;

    private int _hungry;

    #endregion

    #region Public Fields

    public GameObject model;

    public PetData data;

    #endregion

    public void Awake()
    {
        Init();
    }

    public void Init()
    {
        Type = data.type;
        Status = data.status;
        Health = data.health;
        Hungry = data.hungry;
    }

    public virtual void PetSound()
    {
        Debug.Log("Sound that the pet will emit when it is selected");
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


