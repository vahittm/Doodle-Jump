using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    public float speed = 2.0f;
    public Vector3 pointA = new Vector3(-2.3f, 0, 0);
    public Vector3 pointB = new Vector3(2.3f, 0, 0);
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * (speed * direction * Time.deltaTime);

        if (transform.position.x<= pointA.x)
        {
            direction = 1;
        }
       else if (transform.position.x>= pointB.x)
        {
            direction = -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player")
        {
            Destroy(other.gameObject);
        }

        if (other.tag=="Bullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
