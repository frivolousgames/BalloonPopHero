using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetDemoText : MonoBehaviour
{
    public static GameObject ready;
    public GameObject demoShoot;

    GameObject demoShootSpawn;

    //GameObject demoPrefab;

    //bool demoOver;

    private void Awake()
    {
        ready = GameObject.FindGameObjectWithTag("ReadyText");
        demoShootSpawn = GameObject.FindGameObjectWithTag("DemoShoot");
        //
        StartCoroutine("DemoDelay");
        ready.SetActive(false);
    }

    IEnumerator DemoDelay()
    {
        yield return new WaitForSeconds(.5f);
        Instantiate(demoShoot, demoShootSpawn.transform.position, Quaternion.identity, demoShootSpawn.transform);
        yield break;
    }

}
