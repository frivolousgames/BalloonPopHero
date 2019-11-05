using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectBullets : MonoBehaviour
{
    GameObject[] bullets;

    public GameObject hitSound;

    private void Update()
    {
        bullets = GameObject.FindGameObjectsWithTag("Bullet");

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (bullets != null)
        {
            foreach (GameObject bullet in bullets)
            {
                if (other.gameObject == bullet)
                {
                    Destroy(bullet);
                    Instantiate(hitSound, null);

                }
            }
        }
    }
}
