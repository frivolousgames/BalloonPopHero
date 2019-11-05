using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static int bulletAmount;

    private void Awake()
    {
        bulletAmount = 12;
    }
}
