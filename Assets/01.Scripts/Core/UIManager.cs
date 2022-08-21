using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    

    private RectTransform canvasTrm = null;
    private RectTransform fadeImgaeTrm = null;
    private RectTransform optionUITrm = null;
    private RectTransform cookUITrm = null;
    private RectTransform sellUITrm = null;
    private TextMeshProUGUI priceText;

    private bool UIActive = false;
    private RectTransform ActiveUI = null;

    private void Awake() 
    {
        canvasTrm = GameObject.Find("Canvas").GetComponent<RectTransform>();

        fadeImgaeTrm = canvasTrm.Find("FadeImage").GetComponent<RectTransform>();
        optionUITrm = canvasTrm.Find("Option").GetComponent<RectTransform>();
        cookUITrm = canvasTrm.Find("Inventory/Cook").GetComponent<RectTransform>();
        sellUITrm = canvasTrm.Find("Inventory/Sell").GetComponent<RectTransform>();
        priceText = canvasTrm.Find("Image/PriceText").GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        priceText.text = $"{SaveManager.Instance.playerInfo.money}";
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
