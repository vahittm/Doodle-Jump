using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
  public Vector3 pointA = new Vector3(-3.19f, 0, 0);
  public Vector3 pointB = new Vector3(3.19f, 0, 0);
  public float speed = 2f;
  private int direction = 1;
  public float jumpforce = 9f;
  
  
  private void Update()
  {
    transform.position += Vector3.right * (speed * direction * Time.deltaTime);

    if (transform.position.x <= pointA.x)
    {
      direction = 1;
    }
    else if (transform.position.x >= pointB.x)
    {
      direction = -1;
    }
    {
      
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.relativeVelocity.y<=0)
    {
      Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

      if (rb !=null)
      {
        Vector2 velocity = rb.velocity;
        velocity.y = jumpforce;
        rb.velocity = velocity;
        
      }
    }
  }

 
}

