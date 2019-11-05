using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonController : MonoBehaviour
{
    GameObject[] bullets;

    public GameObject explosion;

    GameObject explosionClone;

    public int pointValue;
    int value;

    BoxCollider2D counter;
    Slider ozoneSlider;
    public int damage;
    public int health;

    public GameObject popSound;

    public GameObject damageSound;
    public GameObject sliderBlink;
    Transform sliderBlinkSpawn;
    GameObject canvas;

    public GameObject lostSound;

    public GameObject hitSound;
    SpriteRenderer sr;
    Color original;

    bool recovering;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        original = sr.color;
        ozoneSlider = GameObject.FindGameObjectWithTag("OzoneSlider").GetComponent<Slider>();
        counter = GameObject.FindGameObjectWithTag("Counter").GetComponent<BoxCollider2D>();
        sliderBlinkSpawn = GameObject.FindGameObjectWithTag("SliderBlinkSpawn").transform;
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        if (GameControl.bonusLevel != 0)
        {
            value = pointValue * GameControl.bonusLevel;
        }
        else
        {
            value = pointValue;
        }

    }

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
                    if(recovering != true)

                    health -= SpawnBullet.damage;
                    if (health < 1)
                    {
                        ScoreController.score += value;
                        Instantiate(explosion, transform.position, Quaternion.identity, null);
                        Instantiate(popSound, null);
                        Destroy(gameObject);
                    }
                    else
                    {
                        Instantiate(hitSound, null);   
                        sr.color = Color.red;
                        StartCoroutine("ResetColor");
                    }

                    if (SpawnBullet.bulletType != "Laser")
                    {
                        Destroy(bullet);
                    }
                    recovering = true;
                    StartCoroutine("Recover");
                }
            }            
        }
       
        if (other == counter)
        {
            ozoneSlider.value -= damage;
            if (damageSound != null)
            {
                if (ozoneSlider.value < 1)
                {
                    Instantiate(lostSound, null);
                }
                else
                {
                    Instantiate(damageSound, null);
                }

                Instantiate(sliderBlink, sliderBlinkSpawn.position, Quaternion.identity, canvas.transform);
            }
        }
        if (other.gameObject == GameObject.FindGameObjectWithTag("ExplodeCollider"))
        {

            ScoreController.score += value;
            Instantiate(explosion, transform.position, Quaternion.identity, null);
            Instantiate(popSound, null);
            Destroy(gameObject);
        }
    }
    IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(.1f);
        sr.color = original;
    }
    IEnumerator Recover()
    {
        yield return new WaitForSeconds(.2f);
        recovering = false;
    }
}
