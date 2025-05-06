using System;
using UnityEngine;

public class CoinPool : ObjectPool
{
    public new static CoinPool instance;
    
    public GameObject coinPrefab;
    public int initialPoolSize = 5;

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
        }

    }

    private void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            Push(GetNewObject());
        }
    }

    protected override GameObject GetNewObject()
    {
        GameObject coin = GameObject.Instantiate(coinPrefab);
        coin.SetActive(false);
        coin.transform.parent = transform;
        return coin;
    }
    
}
