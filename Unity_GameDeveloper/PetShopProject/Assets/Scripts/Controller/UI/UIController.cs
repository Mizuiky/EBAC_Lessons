using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private HUD hud;

    [SerializeField]
    private GameObject pauseScreen;

    private GameManager gameManager;

    #endregion

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        hud.Reset();

        pauseScreen.SetActive(false);
    }

    public void UpdateText(IPet petData)
    {
        hud.SetText(petData);
    }

    public void ShowWarning()
    {
        hud.ShowKeyWarning();
    }

    public void ResetHUD()
    {
        hud.Reset();
    }

    public void SetHighlight(HighPoint highPoint)
    {
        hud.ShowHighlight(highPoint);
    }

    public void SetPauseScreenVisibility()
    {
        if(!pauseScreen.activeInHierarchy)
        {
            gameManager.PauseTime(true);
            pauseScreen.SetActive(true);
        }
        else
        {
            gameManager.PauseTime(false);
            pauseScreen.SetActive(false);
        }
    }
}
