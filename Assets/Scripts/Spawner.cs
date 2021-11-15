using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawnPoint;

    private int rand;
    private int randPosition;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, enemies.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(enemies[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
