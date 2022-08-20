using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OliveImage : PoolableMono, IPointerClickHandler
{
    public int cookTime;
    private bool isButtonActive = false;
    public bool cooked = false;
    public int index;
    public Image cookedImage;
    Slider slider;
    
    private void Awake() 
    {
        slider = transform.GetChild(1).GetComponent<Slider>();
    }

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
            GameObject.Find("Player").GetComponent<Player>().DeleteFish(index);
            transform.SetParent(GameManager.Instance.transform);
            PoolManager.Instance.Push(this);
            slider.value = 0;
            slider.gameObject.SetActive(false);
            cooked = false;
        }
    }

    public override void Reset(Transform Trm)
    {
        transform.position = Trm.position;
    }

    public void StartCook()
    {
        CookManager.Instance.StartCook(this);
    }
}
