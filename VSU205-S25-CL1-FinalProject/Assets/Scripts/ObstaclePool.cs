using System;
using UnityEngine;

public class ObstaclePool : ObjectPool
{
    public new static ObstaclePool instance;
    
    public GameObject obstaclePrefab;
    //how many obstacles to pre-instantiate
    public int initialPoolSize = 5; 
    
    protected override void Awake()
    {
        base.Awake(); // Optional: call base logic if needed -
                      // this is because I was originally hiding it by
                      // accident through using just a regular awake
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        //pre-allocate the specified number of obstacles in the pool
        for (int i = 0; i < initialPoolSize; i++)
        {
            //create and return objects to the pool
            Push(GetNewObject());
        }
    }


    protected override GameObject GetNewObject()
    {
        GameObject obstacle = Instantiate(obstaclePrefab);
        obstacle.SetActive(false);
        obstacle.transform.parent = this.transform;
        return obstacle;
    }
    
   
    
    
}
