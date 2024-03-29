using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookManager : MonoBehaviour
{
    public static CookManager Instance;

    private bool isActive1 = false;
    private bool isActive2 = false;
    private bool isActive3 = false;

    private void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void StartCook(OliveImage turtle)
    {
        StartCoroutine(Cook(turtle));
    }

    public IEnumerator Cook(OliveImage turtle)
    {
        if(isActive1) { Cook2(turtle); }

        turtle.a = true;
        Slider slider = turtle.transform.GetChild(0).GetComponent<Slider>();
        float currentTime = 0;     

        isActive1 = true;

        slider.gameObject.SetActive(true);
        while(currentTime < turtle.cookTime)
        {
            currentTime += Time.deltaTime;
            slider.value = currentTime / turtle.cookTime;
            Debug.Log(currentTime);

            yield return new WaitForEndOfFrame();
        }

        currentTime = 0;
        turtle.cooked = true;
        isActive1 = false;
        turtle.a = false;
    }

    private void Cook2(OliveImage turtle)
    {
        if(isActive2) { Cook3(turtle); }

        turtle.a = true;
        Slider slider = turtle.transform.GetChild(0).GetComponent<Slider>();
        float currentTime = 0;

        isActive2 = true;

        slider.gameObject.SetActive(true);
        while(currentTime < turtle.cookTime)
        {
            currentTime += Time.deltaTime;
            slider.value = currentTime / turtle.cookTime;
        }

        currentTime = 0;
        turtle.cooked = true;
        isActive2 = false;
        turtle.a = false;
    }

    private void Cook3(OliveImage turtle)
    {
        if(isActive3) 
        { 
            Debug.Log("is full");
            return;
        }
        
        turtle.a = true;
        Slider slider = turtle.transform.GetChild(0).GetComponent<Slider>();
        float currentTime = 0;

        isActive3 = true;

        slider.gameObject.SetActive(true);
        while(currentTime < turtle.cookTime)
        {
            currentTime += Time.deltaTime;
            slider.value = currentTime / turtle.cookTime;
        }

        currentTime = 0;
        turtle.cooked = true;
        isActive3 = false;
        turtle.a = false;
    }
}
