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
                if (item.bombChance > Random.Range(1, 100)) prefab = bomb;

                var gO = Instantiate(prefab);


                if (item.isRandomPosition)
                {
                    gO.transform.position = new Vector3(Random.Range(-5f,5f), -5, 0);
                }
                else
                {
                gO.transform.position = new Vector3(item.x, -5, 0);
                }


                if (item.isRandomVelocity)
                {
                    gO.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(8f,14f));
                }
                else
                {
                gO.GetComponent<Rigidbody2D>().velocity = item.velocity;
                }
            }
            await new WaitForSeconds(3);
        }
    }
}
