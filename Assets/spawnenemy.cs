using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
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
        Vector3 position = new Vector3(6f, 6f, 6f);
        position.y = Random.Range(5f, 5f);
        position.x = Random.Range(-12f, 6f);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
