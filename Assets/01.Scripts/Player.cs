using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] public List<Turtle> cookTurtleList = new List<Turtle>();
    [SerializeField] public List<Turtle> sellTurtleList = new List<Turtle>();
    [SerializeField] private CookInventory cookInventory;


    private void Start() 
    {
        money = SaveManager.Instance.playerInfo.money;
        cookTurtleList = SaveManager.Instance.playerInfo.cookTurtleList;
        sellTurtleList = SaveManager.Instance.playerInfo.sellTurtleList;
    }

    public void AddFish(Turtle turtle)
    {
        cookTurtleList.Add(turtle);
        cookInventory.AddFish(cookTurtleList.Count - 1, turtle.turtleImgae);
    }
}
