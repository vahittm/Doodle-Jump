using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class MovingPlatform : MonoBehaviour
{
    public GameObject MovingplatformPrefab;
    public int NumofMovingPlat = 50;
    public float lelvelwidth = 3.19f;
    public float minY = .2f;
    public float maxY = 1.2f;
    
    private void Start()
    {
        transform.Translate(new Vector3(.5f, 1f, 0));
        Vector3 spawnposition = new Vector3(0.5f, 1f, 0);

        for (int i = 0; i < NumofMovingPlat; i++)
        {
            spawnposition.y = Random.Range(minY, maxY);
            spawnposition.x = Random.Range(-lelvelwidth, lelvelwidth);
            Instantiate(MovingplatformPrefab, spawnposition, Quaternion.identity);
        }
    }

   
}
    