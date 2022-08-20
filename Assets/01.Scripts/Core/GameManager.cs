using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    [SerializeField] private List<PoolableMono> poolObj = new List<PoolableMono>();
    [SerializeField] private int poolCount = 0;

    private void Awake() 
    {   
        if(Instance == null)
        {
            Instance = this;
        }
        PoolManager.Instance = new PoolManager(this.transform);
        SaveManager.Instance = new SaveManager();
        
        foreach(PoolableMono item in poolObj)
        {
            PoolManager.Instance.CreatePool(item, poolCount);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
