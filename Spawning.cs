using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private float posX;
    private float posZ;


    public GameObject[] enemies;
    public int spawnTime;
    public int delayTime;


    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, delayTime);
    }


    void Spawn()
    {
        posX = Random.Range(-60, 50);
        posZ = Random.Range(-60, 10);

        Instantiate(enemies[0], new Vector3(posX, 1, posZ), Quaternion.identity);
    }
}
