using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBalloonController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 rbVelocity;

    public Vector3 targetPositionIN;
    public Vector3 targetPositionOUT;
    public float moveSpeed;
    public float oSpeed;

    bool targetReached;
    bool wait;
    bool ready;
    bool timeUp;
    bool flownIn;

    float oTime;
    public float oTimeCutoff;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        rb.velocity = rbVelocity;
        if (transform.position == targetPositionIN)
        {
            targetReached = true;
        }

        if(oTime > oTimeCutoff)
        {
            timeUp = true;
        }
        
        if(timeUp != true)
        {
            if (targetReached != true)
            {
                FlyIn();
                rbVelocity = Vector2.zero;
            }
            else
            {
                if(wait != true)
                {
                    StartCoroutine("OscillateCountdown");
                    //transform.position = targetPositionIN;
                    //rbVelocity = Vector2.zero;
                    wait = true;
                }
            }
            if(ready != false)
            {
                Oscillate();
                oTime += Time.deltaTime;
            }
        }
        else
        {
            rbVelocity = Vector2.zero;
            FlyOut();
        }
        
    }
    private void FixedUpdate()
    {
        
    }

    void Oscillate()
    {
        //rb.AddForce(Vector2.down * Time.deltaTime * oSpeed, ForceMode2D.Force);
        //float vel = 0f;
        /*if (rb.velocity.y > 8)
        {
            
        }
        else
        {
            rb.AddForce(-Vector2.down * oSpeed);

        }*/

        rbVelocity = new Vector2(0, Mathf.Lerp(-8, 8, Mathf.PingPong(Time.time, 1)));
        
        //transform.position = new Vector2(transform.position.x, Mathf.Lerp(-3, 3, Mathf.PingPong(Time.time * oSpeed, 1)));
        //rb.velocity = new Vector2(transform.position.x, Mathf.Clamp(0, -5, 5));
        //transform.position = Vector3.Lerp(new Vector3(targetPositionIN.x, targetPositionIN.y - 3, 0), new Vector3(targetPositionIN.x, targetPositionIN.y + 3, 0),  Mathf.PingPong(Time.time, 1));
        //transform.position = new Vector2(transform.position.x, Mathf.SmoothDamp(targetPositionIN.y, targetPositionIN.y - 200, ref vel, .3f));

    }

    void FlyIn()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPositionIN, Time.deltaTime * moveSpeed);
        
        //rb.velocity = rbVelocity;
    }

    void FlyOut()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPositionOUT, Time.deltaTime * moveSpeed);
    }

    IEnumerator OscillateCountdown()
    {
        yield return new WaitForSeconds(.1f);

        ready = true;
    }
}
