using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject explodeParticles;
    Rigidbody2D rb;
    public GameObject leftSide;
    public GameObject rightSide;
    public Color juiceColor;
    public AudioClip spawnSound;
    public AudioClip sliceSound;
    public AudioClip missSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 250;
        AudioSystem.Play(spawnSound);
    }
    private void Update()
    {
        if (transform.position.y < -6)
        {
            Miss();
            AudioSystem.Play(missSound);
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
        Destroy(gameObject);
        if (!CompareTag("Bomb")) Split(particles);
        AudioSystem.Play(sliceSound);
    }
    void Split(GameObject particles)
    {
        // seperate children 
        transform.DetachChildren();
        var leftrb = leftSide.AddComponent<Rigidbody2D>();
        var rightrb = rightSide.AddComponent<Rigidbody2D>();

        leftrb.velocity = rb.velocity + new Vector2(-2, 0);
        rightrb.velocity = rb.velocity + new Vector2(2, 0);

        particles.GetComponent<ParticleSystem>().startColor = juiceColor;
        particles.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = juiceColor;
    }
}
