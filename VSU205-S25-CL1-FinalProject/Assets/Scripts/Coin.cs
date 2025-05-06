using UnityEngine;

public class Coin : MonoBehaviour
{

    //public float rotationSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the coin on screen 
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //+1 per coin
            GameManager.instance.AddScore(1); 
            
            Debug.Log("Coin Collected");
            
            //Remove the coin after its been collected
            //Destroy(gameObject); 
            
            gameObject.SetActive(false);
            
            //the coin should be returned to the pool                                                       // Return the coin to the pool
            CoinPool.instance.Push(gameObject);
            
        }
    }
    
}
