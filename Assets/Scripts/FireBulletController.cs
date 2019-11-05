using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletController : MonoBehaviour
{
    public GameObject fireBomb;

    GameObject[] balloons;

    private void Update()
    {
        balloons = GameObject.FindGameObjectsWithTag("Balloon");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach (GameObject balloon in balloons)
        {
            if(other.gameObject == balloon)
            {
                if(balloon.GetComponent<BalloonController>().health < 2)
                {
                    Instantiate(fireBomb, transform.position, Quaternion.identity, null);

                }
            }
        }
    }
        
    
}
