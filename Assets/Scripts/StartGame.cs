using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject actionObject;
    public GameObject actionSpawn;
    public GameObject canvas;
    public GameObject shootRaycast;
    public GameObject balloonSpawner;
    public Animator anim;

    public GameObject readySound;
    public GameObject goSound;

    public GameObject playSound;

    public static bool shootTime;

    //Text readyText;

    private void Awake()
    {
        shootTime = false;
        //readyText = GetComponent<Text>();
        //StartCoroutine("SetReadyText");
    }

    /*IEnumerator SetReadyText()
    {
        yield return new WaitForSeconds(.1f);
        readyText.text = "READY";

    }*/

    private void Start()
    {
    }

    public void GetReady()
    {
        anim.SetTrigger("Ready");
    }

    public void StartNewGame()
    {

        actionObject.GetComponent<Text>().text = "GO!";
        Instantiate(actionObject, actionSpawn.transform.position, Quaternion.identity, canvas.transform);
        Instantiate(goSound, null);
        shootRaycast.SetActive(true);
        balloonSpawner.SetActive(true);
        Instantiate(playSound, null);
        gameObject.SetActive(false);
        shootTime = true;
    }

    public void ReadySound()
    {
        Instantiate(readySound, null);
    }
    
}
