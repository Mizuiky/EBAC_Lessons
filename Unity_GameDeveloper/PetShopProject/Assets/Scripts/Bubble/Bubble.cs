using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour, IActivate
{
    private float timeToDesapear = 1f;

    [SerializeField]
    private Sprite [] sprites;

    public void Activate()
    {
        ChooseBubbleColor();

        this.gameObject.SetActive(true);       

        Invoke("Deactivate", timeToDesapear);
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
        int index = Random.Range(0, sprites.Length);

        return sprites[index];
    }
}
