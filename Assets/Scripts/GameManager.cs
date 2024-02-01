using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruit;
    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }
    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-5, 5), -5);
        Instantiate(fruit, pos, Quaternion.identity);
    }
}
