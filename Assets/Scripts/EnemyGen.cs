using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public int NumofEnemy = 5;
    public int NumofEnemy2 = 5;
    public int NumofEnemy3 = 5;
    public float levelwidth = 2.3f;

    public float minY = 3.5f;

    public float maxY = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(1.5f,1f,0));
        Vector3 spawnposition = new Vector3(2f, 3.5f, 0);

        for (int i = 0; i < NumofEnemy; i++)
        {
            spawnposition.y = Random.Range(minY, maxY);
            spawnposition.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(enemyPrefab, spawnposition, Quaternion.identity);
        }
        transform.Translate(new Vector3(0.5f,5f,0));
        Vector3 spawnposition2 = new Vector3(0.5f, 5f, 0);
        for (int i = 0; i < NumofEnemy2; i++)
        {
            spawnposition2.y = Random.Range(minY, maxY);
            spawnposition2.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(enemyPrefab2, spawnposition2, Quaternion.identity);
        }
        transform.Translate(new Vector3(1.5f,7f,0));
        Vector3 spawnposition3 = new Vector3(1.5f, 7f, 0);
        
            for (int i = 0; i < NumofEnemy3; i++)
            {
                spawnposition3.y = Random.Range(minY, maxY);
                spawnposition3.x = Random.Range(-levelwidth, levelwidth);
                Instantiate(enemyPrefab3, spawnposition3, Quaternion.identity);
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
