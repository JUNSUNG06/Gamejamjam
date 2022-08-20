using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance = null;
    private RectTransform cook; 
    private RectTransform sell; 
    public List<OliveImage> cookImage = new List<OliveImage>();
    private RectTransform[] cookPos = new RectTransform[20];
    public List<OliveImage> sellImage = new List<OliveImage>();
    private RectTransform[] sellPos = new RectTransform[20];

    private void Awake() 
    {
        cook = transform.Find("Cook/CookPanel").GetComponent<RectTransform>();
        sell = transform.Find("Sell/SellPanel").GetComponent<RectTransform>();

        if(Instance == null)
        {
            Instance = this;
        }    

        for(int i = 0; i < 16; i++)
        {
            cookPos[i] = cook.GetChild(i).GetComponent<RectTransform>();
            sellPos[i] = sell.GetChild(i).GetComponent<RectTransform>();
        }
    }

    private void Update() {
        SetCook();
        SetSell();
    }

    public void CookAdd(OliveImage item)
    {
        if(cookImage.Count < 16)
        {
            cookImage.Add(item);
            item.transform.SetParent(cook);

            SetCook();
        }
    }

    public void CookDelete(OliveImage item)
    {
        cookImage.Remove(item);
    }

    public void SetCook()
    {
        for(int i = 0; i < cookImage.Count; i++)
        {
            cookImage[i].transform.position = cookPos[i].transform.position;
        }
    }

    public void SellAdd(OliveImage item)
    {
        if(sellImage.Count < 16)
        {
            sellImage.Add(item);
            item.transform.SetParent(sell.transform);

            SetSell();
        }
    }

    public void SellDelete(OliveImage item)
    {
        sellImage.Remove(item);
    }

    public void SetSell()
    {
        for(int i = 0; i < sellImage.Count; i++)
        {
            sellImage[i].transform.position = sellPos[i].transform.position;
        }
    }
}
