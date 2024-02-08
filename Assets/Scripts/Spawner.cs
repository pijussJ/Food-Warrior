using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnRate = 1;
    public GameObject fruit;
    public GameObject bomb;
    public float bombChance = 20;

    public List<Wave> waves = new();

    async void Start()
    {
        foreach (var wave in waves)
        {
            foreach (var item in wave.items)
            {
                await new WaitForSeconds(item.delay);
                var prefab = item.isBomb ? bomb : fruit;
                var gO = Instantiate(prefab);
                gO.transform.position = new Vector3(item.x, -5, 0);
                gO.GetComponent<Rigidbody2D>().velocity = item.velocity;
            }
            await new WaitForSeconds(3);
        }
    }
}
