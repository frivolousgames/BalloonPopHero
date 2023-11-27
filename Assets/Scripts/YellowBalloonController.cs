using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBalloonController : MonoBehaviour
{
    Rigidbody2D rb;
    public float hSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Mathf.Lerp(-1, 5 + 5f, Mathf.PingPong(Time.time * hSpeed, 1)),Mathf.Lerp(-10, 11, Mathf.PingPong(Time.time, 1)));

    }
}
