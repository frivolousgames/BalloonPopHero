using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunArmEnabler : MonoBehaviour
{
    public GameObject gunArm;
    public Animator anim;

    public GameObject bulletCounter;

    public void EnableGunArm()
    {
        if (!gunArm.activeInHierarchy)
        {
            gunArm.SetActive(true);

        }
        else
        {
            gunArm.SetActive(false);

        }
    }

    public void Shoot()
    {
        anim.SetTrigger("Shoot");
    }

    public void EnableBulletCounter()
    {
        bulletCounter.SetActive(true);
    }
}
