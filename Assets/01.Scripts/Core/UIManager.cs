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
    private Text failTxt;
    private Text successTxt;

    private void Awake() 
    {
        UIManager.Instance = this;
        canvasTrm = GameObject.Find("Canvas").GetComponent<RectTransform>();

        fadeImgaeTrm = canvasTrm.Find("FadeImage").GetComponent<RectTransform>();
        optionUITrm = canvasTrm.Find("Option").GetComponent<RectTransform>();
        cookUITrm = canvasTrm.Find("Inventory/Cook").GetComponent<RectTransform>();
        sellUITrm = canvasTrm.Find("Inventory/Sell").GetComponent<RectTransform>();
        failTxt = canvasTrm.Find("FailTxt").GetComponent<Text>();
        successTxt = canvasTrm.Find("SuccessTxt").GetComponent<Text>();
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
    public void setFailText(){
        StartCoroutine(SetFailText());
    }
    public void setSuccessText(){
        StartCoroutine(SetSuccessText());
    }
    IEnumerator SetFailText(){
        Sequence seq = DOTween.Sequence();
        failTxt.transform.position = new Vector3(failTxt.transform.position.x,failTxt.transform.position.y +100, 0);
        failTxt.gameObject.SetActive(true);
        seq.Append(failTxt.transform.DOMove(new Vector3(failTxt.transform.position.x,failTxt.transform.position.y -100,0), 0.2f));
        yield return new WaitForSeconds(0.2f);
        seq.Append(failTxt.transform.DOMove(new Vector3(failTxt.transform.position.x,failTxt.transform.position.y +10,0), 0.1f));
        yield return new WaitForSeconds(0.1f);
        seq.Append(failTxt.transform.DOMove(new Vector3(failTxt.transform.position.x,failTxt.transform.position.y -10,0), 0.1f));
        yield return new WaitForSeconds(0.3f);
        failTxt.gameObject.SetActive(false);
    }
    IEnumerator SetSuccessText(){
        Sequence seq = DOTween.Sequence();
        successTxt.gameObject.SetActive(true);
        seq.Append(successTxt.transform.DOScale(new Vector3(1.5f,1.5f,0), 0.2f));
        yield return new WaitForSeconds(0.2f);
        seq.Append(successTxt.transform.DOScale(new Vector3(0.7f,0.7f,0), 0.2f));
        yield return new WaitForSeconds(0.5f);
        successTxt.gameObject.SetActive(false);
    }
}
