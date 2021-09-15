using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.velocity = Vector2.left * 5.0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wallBack")
        {
            Destroy(gameObject);
        }
    }
}
