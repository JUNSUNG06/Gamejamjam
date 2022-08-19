using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager
{
    public static PoolManager Instance = null;
    private Dictionary<string, Pool<PoolableMono>>  pools = new Dictionary<string, Pool<PoolableMono>>();
    private Transform parent = null;

    public PoolManager(Transform _parent)
    {
        parent = _parent;
    }

    public void CreatePool(PoolableMono prefab, int cnt)
    {
        Pool<PoolableMono> _pool = new Pool<PoolableMono>(parent, prefab, cnt);
        pools.Add(prefab.name, _pool);
    }

    public PoolableMono Pop(string name)
    {
        PoolableMono obj = pools[name].Pop(parent);

        return obj;
    }

    public void Push(PoolableMono obj)
    {
        pools[obj.name].Push(obj);
    }
}
