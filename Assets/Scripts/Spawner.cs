using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnRate = 1;
    public GameObject fruit;
    public GameObject bomb;
    public float bombChance = 20;
    private void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnRate);
    }
    void Spawn()
    {
        var prefab = Random.Range(0,100) < (100 - bombChance) ? fruit : bomb;

        Vector3 pos = new Vector3(Random.Range(-5f, 5f), -5);
        var obj = Instantiate(prefab, pos, Quaternion.identity);
    }
}
