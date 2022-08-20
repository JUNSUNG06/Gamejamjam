using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchZoon : MonoBehaviour
{
    [SerializeField]UnityEvent e;
    private void OnMouseDown() 
    {
        if(gameObject.activeSelf == true)
        {
            e?.Invoke();
            //플레이어 에니메이션 실행
            GameObject.Find("Fishing").GetComponent<Fishing>().StartFishing();
            gameObject.SetActive(false);
        }    
    }
}
