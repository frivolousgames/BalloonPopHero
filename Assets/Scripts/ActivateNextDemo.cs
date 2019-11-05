using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextDemo : MonoBehaviour
{
    public GameObject demoReload;
    GameObject demoReloadSpawn;

    public GameObject wahSound;

    private void Awake()
    {
        demoReloadSpawn = GameObject.FindGameObjectWithTag("DemoReload");
        Instantiate(wahSound, null);

    }

    public void ActivateDemo02()
    {
        Instantiate(demoReload, demoReloadSpawn.transform.position, Quaternion.identity, demoReloadSpawn.transform);
    }
}
