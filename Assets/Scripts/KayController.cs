using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayController : MonoBehaviour
{
    public Animator anim;
    AnimatorStateInfo animInfo;

    bool lost;
    bool shoot;

    float shotPause;

    private void Awake()
    {
        shotPause = .45f;
    }

    private void Update()
    {
        animInfo = anim.GetCurrentAnimatorStateInfo(0);
        lost = GameControl.lost;
        anim.SetBool("Lost", lost);
    }

    public void Shoot()
    {
        if(StartGame.shootTime != false)
        {
            if (lost != true && BulletCounter.bullets > 0)
            {
                if (animInfo.shortNameHash != Animator.StringToHash("Shoot"))
                {
                    if (shoot == false)
                    {
                        shoot = true;
                        anim.SetTrigger("Shoot");
                        StartCoroutine("ShotPause");
                    }
                }
            }
        }
    }

    IEnumerator ShotPause()
    {
        yield return new WaitForSeconds(shotPause);
        shoot = false;
    }
    public void StartShooting()
    {
        anim.SetTrigger("Ready");
    }

    public void Lose()
    {
        lost = true;
    }

    public void Reload()
    {
        if (animInfo.shortNameHash != Animator.StringToHash("Reload"))
        {
            anim.SetTrigger("Reload");
        }
    }
    public void Retry()
    {
        anim.SetTrigger("Retry");
    }
}
