using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] public List<Turtle> turtleList = new List<Turtle>();

    private void Awake() 
    {
        money = SaveManager.Instance.playerInfo.money;
        turtleList = SaveManager.Instance.playerInfo.turtleList;
    }
}
