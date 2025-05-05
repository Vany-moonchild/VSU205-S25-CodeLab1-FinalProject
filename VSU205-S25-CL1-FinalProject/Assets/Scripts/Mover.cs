using UnityEngine;

public class Mover : MonoBehaviour
{

    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        //if game is over
        if (GameManager.instance.isGameOver == true)
        {
            //stop moving the objects
            speed = 0;
        }
        else //otherwise 
        {
            //continue to move all obstacles
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
    
    
}
