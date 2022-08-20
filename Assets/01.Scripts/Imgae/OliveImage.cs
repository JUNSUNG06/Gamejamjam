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
    public Sprite cookedImage;
    public Sprite defaultImage;
    public bool etc;
    Slider slider;
    
    private void Awake() 
    {
        slider = transform.GetChild(1).GetComponent<Slider>();
    }

    private void Update() 
    {
        if(cooked)
        {
            this.GetComponent<Image>().sprite = cookedImage;
            slider.gameObject.SetActive(false);
        }
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
            slider.value = 0;
            this.GetComponent<Image>().sprite = defaultImage;
            cooked = false;
            PoolManager.Instance.Push(this);
        }
    }

    public override void Reset(Transform Trm)
    {
        transform.position = Trm.position;
    }

    public void StartCook()
    {
        CookManager.Instance.StartCook(this);
        if(etc)
        {
            GameObject.Find("Player").GetComponent<Player>().DeleteFish(index);
            transform.SetParent(GameManager.Instance.transform);
            slider.value = 0;
            this.GetComponent<Image>().sprite = defaultImage;
            cooked = false;
            PoolManager.Instance.Push(this);
        }
    }
}
