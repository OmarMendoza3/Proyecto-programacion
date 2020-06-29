using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnroca : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject prefab3;
    public float timeBetweenSpawns = 1f;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, timeBetweenSpawns);
    }
    void Spawn()
    {
        Vector3 position = new Vector3(2f, 8f, 0f);
        position.y = Random.Range(3f, 4f);
        position.x = Random.Range(-4f, 4f);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
