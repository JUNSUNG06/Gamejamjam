using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]List<Turtle> turtles = new List<Turtle>();
    [SerializeField] private List<PoolableMono> poolObj = new List<PoolableMono>();
    [SerializeField] private int poolCount = 0;

    private void Awake() 
    {   
        PoolManager.Instance = new PoolManager(this.transform);
        
        foreach(PoolableMono item in poolObj)
        {
            PoolManager.Instance.CreatePool(item, poolCount);
        }
    }
}
