using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fishs : PoolableMono,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public override void Reset(Transform Trm)
    {
        throw new System.NotImplementedException();
    }
}
