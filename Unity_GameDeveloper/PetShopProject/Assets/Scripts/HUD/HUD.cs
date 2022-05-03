using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Pet Attributes")]
    #region Public Fields

    public Text type;
    public Text status;
    public Text health;
    public Text hungry;

    public Text warning;

    public List<Bar> highlightBar;

    #endregion

    public void SetText(IPet pet)
    {
        type.text = pet.Type.ToString();
        status.text = pet.Status.ToString();
        health.text = pet.Health.ToString();
        hungry.text = pet.Hungry.ToString();
    }

    public void ShowKeyWarning()
    {    
        StartCoroutine(KeyWarning());            
    }

    private IEnumerator KeyWarning()
    {
        warning.text = "Couldn't select pet, please press A, S or D";

        yield return new WaitForSeconds(1);

        Reset();
    }

    public void Reset()
    {
        #region Text

        type.text = "";
        status.text = "";
        health.text = "";
        hungry.text = "";
        warning.text = "";

        #endregion

        #region Bars

        ShowHighlight(HighPoint.None);
        #endregion
    }

    public void ShowHighlight(HighPoint hightLight)
    {
        foreach(Bar bar in highlightBar)
        {
            var show = bar.highlight == hightLight;
            EnableHighlight(bar.bar, show);          
        }
    }

    private void EnableHighlight(GameObject obj, bool enable)
    {
        obj.gameObject.SetActive(enable);
    }
}

    public enum HighPoint
    {
        None,
        left,
        Middle,
        Right
    }

    [System.Serializable]
    public class Bar
    {
        public HighPoint highlight;
        public GameObject bar;
    }
