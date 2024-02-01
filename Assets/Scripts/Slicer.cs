using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        Application.targetFrameRate = 60;
        if(!Application.isEditor)Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        //transform.position = worldPos;
        rb.MovePosition(worldPos);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
