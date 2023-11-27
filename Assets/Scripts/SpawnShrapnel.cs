using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShrapnel : MonoBehaviour
{
    public GameObject shrapnel;

    private void OnDestroy()
    {
        Instantiate(shrapnel, transform.position, Quaternion.identity, null);
    }
}
