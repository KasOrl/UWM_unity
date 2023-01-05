using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float maxWalkSpeed = 3;
    public float jumpSpeed = 6;
 
    Vector3 playerVelocity;
 
    void Start()
    {
        playerVelocity = Vector3.zero;
    }
    
    void Update()
    {
        playerVelocity.x = Input.GetAxis("Horizontal") * maxWalkSpeed;
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerVelocity.y = jumpSpeed;
        }
        else
        {
            playerVelocity.y = GetComponent<Rigidbody2D>().velocity.y;
        }
    
        GetComponent<Rigidbody2D>().velocity = playerVelocity;
    }
}
