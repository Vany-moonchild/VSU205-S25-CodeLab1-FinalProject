using UnityEngine;

public class ObstacleSpawner : BaseSpawner
{
   
   
   void Start()
   {
      //start repeating the spawn action 
      InvokeRepeating("SpawnObstacle", 1, spawnInterval);
   }

   void SpawnObstacle()
   {
      //Uses the method from BaseSpawner
      SpawnObject();
   }
}
