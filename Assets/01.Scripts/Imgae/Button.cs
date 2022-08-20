using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("sldjfhkjdfgisdfhgsjdfo");
        SoundManager.Instance.SetSound(SoundManager.Instance.processingSound);
        transform.parent.GetComponent<OliveImage>().StartCook();
        gameObject.SetActive(false);
    }
}
