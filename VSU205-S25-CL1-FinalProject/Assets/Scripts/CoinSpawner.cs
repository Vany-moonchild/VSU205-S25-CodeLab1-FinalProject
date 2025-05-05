using UnityEngine;

public class CoinSpawner : BaseSpawner
{
    public float minCoinHeight = 0f;
    public float maxCoinHeight = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Start repeating the spawn action 
        //repeat every spawnInterval seconds
        InvokeRepeating("SpawnCoin", 1, spawnInterval);
    }
    
    void SpawnCoin()
    {
        //randomize the Y position within the range 
        float randomY = Random.Range(minCoinHeight, maxCoinHeight);
        
        //altering the rotation of the coin prefab
        Quaternion coinRotation = Quaternion.Euler(90, 0, 0);
        
        //altering the height of the coin prefab
       spawnPosition = new Vector3(spawnPosition.x, randomY, spawnPosition.z);
        
        
        SpawnObject(coinRotation);
    }
}
