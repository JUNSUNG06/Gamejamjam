using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchZoon : MonoBehaviour
{
    private void OnMouseDown() 
    {
        if(gameObject.activeSelf == true)
        {
            //플레이어 에니메이션 실행
            GameObject.Find("Fishing").GetComponent<Fishing>().StartFishing();
            gameObject.SetActive(false);
        }    
    }
}
