using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    [SerializeField] private List<PoolableMono> poolObj = new List<PoolableMono>();
    [SerializeField] private int poolCount = 0;
    [SerializeField] private RectTransform image;
    public AudioClip[] a;

    private void Awake() 
    {   
        if(Instance == null)
        {
            Instance = this;
        }
        SoundManager.Instance = new SoundManager(a);
        PoolManager.Instance = new PoolManager(this.transform);
        SaveManager.Instance = new SaveManager();
        
        foreach(PoolableMono item in poolObj)
        {
            PoolManager.Instance.CreatePool(item, poolCount);
        }

        image.DOMoveY(1080, 3f).SetEase(Ease.Linear);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
