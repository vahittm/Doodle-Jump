using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class doodler : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    public float movementSpeed = 10f;
    float movement ;
    Rigidbody2D rb;
    private float TopScore ;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (movement < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        
        
        
        if (rb.velocity.y>0 && transform.position.y > TopScore)
        {
            TopScore = transform.position.y;
        }
        scoreText.text = "Youre Score:" + Mathf.Round(TopScore);
        
        
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
       if (Input.GetKeyDown(KeyCode.Space))
       {
           Instantiate(BulletPrefab, transform.position, Quaternion.identity);
       }
    }

     void FixedUpdate()
     {
         Vector2 velocity = rb.velocity;
         velocity.x = movement;
         rb.velocity = velocity;
     }
}

