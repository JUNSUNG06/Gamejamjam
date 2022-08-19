using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    private RectTransform canvasTrm = null;
    private RectTransform fadeImgaeTrm = null;
    private RectTransform optionUITrm = null;
    private RectTransform cookUITrm = null;
    private RectTransform sellUITrm = null;

    private bool UIActive = false;
    private RectTransform ActiveUI = null;

    private void Awake() 
    {
        canvasTrm = GameObject.Find("Canvas").GetComponent<RectTransform>();

        fadeImgaeTrm = canvasTrm.Find("FadeImage").GetComponent<RectTransform>();
        optionUITrm = canvasTrm.Find("Option").GetComponent<RectTransform>();
        cookUITrm = canvasTrm.Find("Cook").GetComponent<RectTransform>();
        sellUITrm = canvasTrm.Find("Sell").GetComponent<RectTransform>();
    }

    public void ExitUI()
    {
        UIActive = false;
        ActiveUI.gameObject.SetActive(false);
        ActiveUI = null;
    }

    public void EnterUI(string name)
    {
        switch(name)
        {
        case "Option":
            ActiveUI = optionUITrm;
            break;
        case "Cook":
            ActiveUI = cookUITrm;
            break;
        case "Sell":
            ActiveUI = sellUITrm;
            break;
        }
        
        ActiveUI.gameObject.SetActive(true);
        UIActive = true;
    }
}
