using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    public float speed = 1;

    Rigidbody rb;
    

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        //wake up physics at the beginning 
        rb.sleepThreshold = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed);
        }
    }
    
    //when player hits an obstacle gameOver
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Collision with: " + other.gameObject.name);
        //using compareTag is better optimization than .tag
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //Debug.Log("Hit obstacle! Triggering GameOver.");
            GameManager.instance.GameOver();
        }
    }
    
    
}
