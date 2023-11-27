using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateReadyText : MonoBehaviour
{
    GameObject ready;
    public GameObject wahSound;

    private void Awake()
    {
        ready = SetDemoText.ready;
        Instantiate(wahSound, null);
        //ready = GameObject.FindGameObjectWithTag("ReadyText");
    }

    public void SetReady()
    {
        ready.SetActive(true);
    }
}
