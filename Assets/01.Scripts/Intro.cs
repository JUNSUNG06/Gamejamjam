using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    [SerializeField] private RectTransform image;
    void Update()
    {
        if(Input.anyKeyDown)
        {
            image.DOMoveY(0, 3f).SetEase(Ease.Linear).OnComplete(() => SceneManager.LoadScene("SampleScene"));
        }
    }
}
