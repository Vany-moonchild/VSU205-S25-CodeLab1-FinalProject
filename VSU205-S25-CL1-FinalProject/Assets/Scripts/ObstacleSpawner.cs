using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ObstacleSpawner : BaseSpawner
{
   
   public float spawnX = 15f; 
   public float minObstacleHeight = -1f;
   public float maxObstacleHeight = 10f;
   void Start()
   {
      // Ensure the pool is initialized properly first
      if (ObjectPool.instance != null)
      {
         // Start repeating the spawn action
         InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
      }
      else
      {
         Debug.LogError("ObstaclePool instance is not initialized! Make sure the pool exists in the scene.");
      }
      
   }

   void SpawnObstacle()
   {

      float randomY = Random.Range(minObstacleHeight, maxObstacleHeight);
      
      //altering the height of the coin prefab
      spawnPosition = new Vector3(spawnX, randomY, 0f);
      
      if (ObjectPool.instance != null)
      {
         GameObject obstacle = ObstaclePool.instance.Get();
         obstacle.transform.position = spawnPosition;
         SpawnObject(obstacle); // Use BaseSpawner method to position and activate it
      }
      else
      {
         Debug.LogError("ObstaclePool.instance is null during SpawnObstacle.");
      }
      //
      // GameObject obstacle = ObjectPool.instance.Get();
      // //Uses the method from BaseSpawner
      // SpawnObject(obstacle);
   }
}
