using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    public GameObject objectPrefab;  // The object prefab to spawn
    public float spawnInterval = 2f;  // Time interval between spawns
    public Vector3 spawnPosition;  // Position where the object will spawn

    // This method can be used to spawn objects
    public void SpawnObject()
    {
        // Spawning the object at the specified spawn position with no rotation
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
    }
    
    //this method allows for a custom rotation to be passed 
    public void SpawnObject(Quaternion rotation)
    {
        Instantiate(objectPrefab, spawnPosition, rotation);
    }
    

    
}