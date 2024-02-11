using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject explodeParticles;
    Rigidbody2D rb;
    public GameObject leftSide;
    public GameObject rightSide;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 250;
    }
    private void Update()
    {
        if (transform.position.y < -6)
        {
            Miss();
        }
    }
    void Miss()
    {
        print(":(");
        Destroy(gameObject);
    }

    public void Slice()
    {
        var particles = Instantiate(explodeParticles);
        particles.transform.position = transform.position;

        // seperate children 
        transform.DetachChildren();
        var leftrb = leftSide.AddComponent<Rigidbody2D>();
        var rightrb = rightSide.AddComponent<Rigidbody2D>();

        leftrb.velocity = rb.velocity + new Vector2(-2, 0);
        rightrb.velocity = rb.velocity + new Vector2(2,0) ;

        Destroy(gameObject);
    }
}
