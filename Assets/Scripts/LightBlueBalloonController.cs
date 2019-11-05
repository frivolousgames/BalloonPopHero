using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlueBalloonController : MonoBehaviour
{
    Rigidbody2D rb;
    public float hSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Mathf.Lerp(-8, 8, Mathf.PingPong(Time.time, 1)), Mathf.Lerp(-rb.velocity.y, rb.velocity.y + 5f, Mathf.PingPong(Time.time * hSpeed, 1)));

    }
}
