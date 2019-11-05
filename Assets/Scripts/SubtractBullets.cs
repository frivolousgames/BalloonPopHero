using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractBullets : MonoBehaviour
{
    public void SubtractBullet()
    {
        if (BulletCounter.bullets > 0)
        {
            BulletCounter.bullets--;
        }
    }
}
