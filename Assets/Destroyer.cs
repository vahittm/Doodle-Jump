using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Destroyer : MonoBehaviour
{
    public GameObject player;

    public GameObject platformprefab;

    public GameObject mayplat;
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
        mayplat = (GameObject)Instantiate(platformprefab, new Vector2(Random.Range(-3.3f,3.3f),player.transform.position.y+(14+Random.Range(0.5f,1f))), Quaternion.identity);
        Destroy(other.gameObject);
    }
}
