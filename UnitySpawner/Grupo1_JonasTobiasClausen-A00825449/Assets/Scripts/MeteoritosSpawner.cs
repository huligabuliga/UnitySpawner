using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritosSpawner : MonoBehaviour
{
    public GameObject metoritos;
    float randX;

    Vector2 spawnPoint;
    public float spawnRate = 1f;
    float nextSpawn = 4f;

    public int spawnTime;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8f, 8f);
            spawnPoint = new Vector2(randX, 6);
            Instantiate(metoritos, spawnPoint, Quaternion.identity);
        }

    }

}
