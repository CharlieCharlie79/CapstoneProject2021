using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnTime = 3f;
    public float startTime = 5f;

    public float timer = 60f;

    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <=0)
        {
            Destroy(gameObject);
        }
    }

}
