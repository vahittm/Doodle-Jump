using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformprefab;
    public GameObject movingplatformprefab;
    public int numofplatforms = 200;
    public int numofMplatform = 50;
    public float levelwidth = 3f;
    public float minY = 0.2f;
    public float maxY =0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3());
        Vector3 spawnPosition = new Vector3();
        
        for (int i = 0; i < numofplatforms ; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(platformprefab, spawnPosition, Quaternion.identity);
        }
        
        transform.Translate(new Vector3());
        Vector3 spawnPositions = new Vector3();

        for (int i = 0; i < numofMplatform; i++)
        {
            spawnPositions.y = Random.Range(minY, maxY);
            spawnPositions.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(movingplatformprefab, spawnPositions, Quaternion.identity);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
