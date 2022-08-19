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

    private void Awake() 
    {
        canvasTrm = GameObject.Find("Canvas").GetComponent<RectTransform>();

        fadeImgaeTrm = canvasTrm.Find("FadeImage").GetComponent<RectTransform>();
    }
}
