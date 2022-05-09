using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour, IActivate
{
    private float _timeToDesapear = 1f;

    [SerializeField]
    private Sprite [] _sprites;

    public void Activate()
    {
        ChooseBubbleColor();

        this.gameObject.SetActive(true);       

        Invoke("Deactivate", _timeToDesapear);
    }

    public void Deactivate()
    {
        this.gameObject.SetActive(false);
    }

    public void ChooseBubbleColor()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = GetRandomBubble();
    }

    public Sprite GetRandomBubble()
    {
        int index = Random.Range(0, _sprites.Length);

        return _sprites[index];
    }
}
