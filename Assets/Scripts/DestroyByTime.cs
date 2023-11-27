using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float time;

    private void Awake()
    {
        StartCoroutine("DestroyMe");
    }

    IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
