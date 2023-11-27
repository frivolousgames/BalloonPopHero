using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePitch : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<AudioSource>().pitch = Random.Range(1f, 1.06f);
    }
}
