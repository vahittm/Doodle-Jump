using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag=="NPlatform")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag=="MPlatform")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag=="Enemy1")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag=="Enemy2")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag=="Hole")
        {
            Destroy(other.gameObject);
        }
        {
            
        }

        {
            
        }
        
    }
}
