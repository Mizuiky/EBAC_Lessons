using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private HUD _hud;

    [SerializeField]
    private GameObject _pauseScreen;

    [SerializeField]
    private GameObject _mainMenuScreen;

    private GameManager _gameManager;

    #endregion

    private void Start()
    {
        _gameManager =FindObjectOfType<GameManager>();

        _hud.Reset();

        _mainMenuScreen.SetActive(true);

        _pauseScreen.SetActive(false);
    }

    public void UpdateText(IPet petData)
    {
        _hud.SetText(petData);
    }

    public void ShowWarning()
    {
        _hud.ShowKeyWarning();
    }

    public void ResetHUD()
    {
        _hud.Reset();
    }

    public void SetHighlight(HighPoint highPoint)
    {
        _hud.ShowHighlight(highPoint);
    }

    public void SetPauseScreenVisibility()

    {
        if(!_pauseScreen.activeInHierarchy)
        {
            _gameManager.PauseTime(true);
            _pauseScreen.SetActive(true);
        }
        else
        {
            _gameManager.PauseTime(false);
            _pauseScreen.SetActive(false);
        }
    }

    public void SetMainMenuScreenVisibility()
    {
        if (_mainMenuScreen.activeInHierarchy)
        {    
             _gameManager.PauseTime(false);
            _mainMenuScreen.SetActive(false);
        }
        else
        {
            _gameManager.PauseTime(true);
            _mainMenuScreen.SetActive(true);
        }
    }
}
