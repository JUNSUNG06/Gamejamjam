using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] public List<Turtle> cookTurtleList = new List<Turtle>();
    [SerializeField] public List<Turtle> sellTurtleList = new List<Turtle>();
    [SerializeField] private CookInventory cookInventory;
    [SerializeField] private Animator anim;


    private void Start() 
    {
        money = SaveManager.Instance.playerInfo.money;
        cookTurtleList = SaveManager.Instance.playerInfo.cookTurtleList;
        sellTurtleList = SaveManager.Instance.playerInfo.sellTurtleList;
    }

    public void AddFish(Turtle turtle)
    {
        cookTurtleList.Add(turtle);
        cookInventory.AddFish(cookTurtleList.Count - 1, turtle);
    }
<<<<<<< Updated upstream
    public void StartFishing(){
        anim.SetTrigger("isCatch");
=======

    public void DeleteFish(int index)
    {
        cookTurtleList.RemoveAt(index);
        cookInventory.DeleteFish(index);
>>>>>>> Stashed changes
    }
}
