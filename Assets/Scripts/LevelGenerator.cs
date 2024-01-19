using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformprefab;
    public int numofplatforms = 200;
    public float levelwidth = 3.19f;
    public float minY = 0.5f;
    public float maxY =1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(1f,-6f,0));
        Vector3 spawnPosition = new Vector3(1f,-6,0);
        
        for (int i = 0; i < numofplatforms ; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(platformprefab, spawnPosition, Quaternion.identity);
        }
        
    }
      
    }

    

