using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool <T> where T: PoolableMono
{
    Transform parent = null;
    T prefab = null; 
    Stack<T>pool;

    public Pool(Transform _parent, T _prefab, int cnt)
    {
        parent = _parent;
        prefab = _prefab;

        for(int i = 0; i < cnt; i++)
        {
            T obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            pool.Push(obj);
        }
    }

    public T Pop(Transform Trm)
    {
        T obj = null;

        if(pool.Count <= 0)
        {
            obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.name.Replace("(Clone)", "");
        }
        else 
        {
            obj = pool.Pop();   
        }

        obj.gameObject.SetActive(true);
        obj.Reset(Trm);

        return obj;
    }

    public void Push(T obj)
    {
        obj.gameObject.SetActive(false);
        pool.Push(obj);
    }
}
