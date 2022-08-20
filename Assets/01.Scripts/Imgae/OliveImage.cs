using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OliveImage : PoolableMono, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public override void Reset(Transform Trm)
    {
        transform.position = Trm.position;
    }
}
