using UnityEngine;

[CreateAssetMenu]
public class PetData : ScriptableObject
{
    public Type type ;

    public Status status;

    public int health;

    public int hungry;

    public HighPoint hightlightPosition;
}
