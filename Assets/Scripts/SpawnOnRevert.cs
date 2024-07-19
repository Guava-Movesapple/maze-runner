using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnRevert : MonoBehaviour
{
    public GameObject spawnPrefab;
    public GameObject logic;
    private GameObject enemy;

    private void Start()
    {
        spawn();
    }

    private void Update()
    {

    }

    public void spawn()
    {
       GameObject enemy =  Instantiate(spawnPrefab);

    }

    public void deSpawn()
    {
        Destroy(enemy);
    }
}
