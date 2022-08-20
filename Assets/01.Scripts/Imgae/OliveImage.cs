using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OliveImage : PoolableMono, IPointerClickHandler
{
    public int cookTime;
    public bool cooked = false;
    public bool isProduct = false;
    public Sprite cookedImage;
    public Sprite defaultImage;
    public bool etc;
    Slider slider;
    
    private void Awake() 
    {
        slider = transform.GetChild(0).GetComponent<Slider>();
    }

    public override void Reset(Transform Trm)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(1);
        if(etc)
        {
            Inventory.Instance.CookDelete(this);
            PoolManager.Instance.Push(this);
        }

        if(isProduct)
        {
            Inventory.Instance.SellDelete(this);
            PoolManager.Instance.Push(this);
            this.GetComponent<Image>().sprite = defaultImage;
        }

        if(cooked)
        {
            GoToSell();
            return;
        }

        CookManager.Instance.StartCook(this);
    }

    public void GoToSell()
    {
        Inventory.Instance.CookDelete(this);
        Inventory.Instance.SellAdd(this);
        this.GetComponent<Image>().sprite = cookedImage;
        isProduct = true;
        cooked = false;
    }
}
