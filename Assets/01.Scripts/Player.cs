using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] private Animator anim;


    private void Start() 
    {
        money = SaveManager.Instance.playerInfo.money;
    }
}
