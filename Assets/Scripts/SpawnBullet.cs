using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject defaultBullet;
    public Transform bulletSpawn;
    public GameObject sprayBullet;
    public GameObject explodeBullet;
    public GameObject laserBullet;
    public GameObject waveBullet;
    public GameObject fireBullet;
    GameObject bullet;

    public GameObject shotSound;
    public static string bulletType;
    public static int damage;

    private void Awake()
    {
        bulletType = default;
    }

    public void BulletSpawn()
    {
        Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation, null);
        Instantiate(shotSound, null);
    }
    private void Update()
    {
        switch (bulletType)
        {
            case "Spray":
                bullet = sprayBullet;
                damage = 1;
                break;
            case "Explode":
                bullet = explodeBullet;
                damage = 1;
                break;
            case "Laser":
                bullet = laserBullet;
                damage = 1;
                break;
            case "Wave":
                bullet = waveBullet;
                damage = 2;
                break;
            case "Fire":
                bullet = fireBullet;
                damage = 1;
                break;
            default:
                bullet = defaultBullet;
                damage = 1;
                break;
        }
    }
    /*IEnumerator ResetDefaultAmmo()
    {
        yield return new WaitForSeconds(waitTime);
        SpawnBullet.bulletType = default;
    }*/
}
