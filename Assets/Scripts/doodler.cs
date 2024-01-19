using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class doodler : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       movement= Input.GetAxis("Horizontal")* movementSpeed;
       if (transform.position.x < -3.55f)
       {
           transform.position = new Vector3(3.55f, transform.position.y, 0);
           
       }
       else if (transform.position.x>3.55f)
       {
           transform.position = new Vector3(-3.55f, transform.position.y, 0);
       }
       {
           
       }
    }

     void FixedUpdate()
     {
         Vector2 velocity = rb.velocity;
         velocity.x = movement;
         rb.velocity = velocity;
     }
}

