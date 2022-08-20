using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OliveImage : PoolableMono, IPointerClickHandler
{
    public int cookTime;
    private bool isButtonActive = false;
    public bool cooked = false;
    

    private void OnEnable() 
    {
        isButtonActive = false;
        transform.GetChild(0).gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isButtonActive = !isButtonActive;
        transform.GetChild(0).gameObject.SetActive(isButtonActive);
        
        if(cooked)
        {
            gameObject.SetActive(false);
        }
    }

    public override void Reset(Transform Trm)
    {
        transform.position = Trm.position;
    }

    public void StartCook()
    {
        StartCoroutine(CookManager.Instance.Cook(this));
    }
}
