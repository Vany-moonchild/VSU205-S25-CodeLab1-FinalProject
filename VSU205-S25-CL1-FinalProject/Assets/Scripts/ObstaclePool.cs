using UnityEngine;

public class ObstaclePool : ObjectPool
{
    [SerializeField] private GameObject obstaclePrefab;

    protected override GameObject GetNewObject()
    {
        GameObject obj = Instantiate(obstaclePrefab);
        obj.SetActive(false);
        return obj;
    }
}
