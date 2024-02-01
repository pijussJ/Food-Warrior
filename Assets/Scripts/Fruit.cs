using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(10,15));
        rb.angularVelocity = 250;
    }
    private void Update()
    {
        if (transform.position.y < -6)
        {
            print(":(");
            Destroy(gameObject);
        }
    }
}
