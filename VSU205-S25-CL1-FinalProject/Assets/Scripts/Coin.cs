using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //+1 per coin
            GameManager.instance.AddScore(1); 
            
            Debug.Log("Coin Collected");
            
            //Remove the coin after its been collected
            Destroy(gameObject);
        }
    }
    
}
