using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnReloadText : MonoBehaviour
{
    public GameObject actionObject;
    Text actionText;
    public GameObject canvas;
    public GameObject actionSpawn;

    private void Awake()
    {
        actionText = actionObject.GetComponent<Text>();
    }

    public void SpawnActionText()
    {
        if(GameControl.lost != true)
        {
            actionText.text = "RELOAD";
            Instantiate(actionObject, actionSpawn.transform.position, Quaternion.identity, canvas.transform);
            gameObject.SetActive(false);
        }
        
    }
    private void Update()
    {
        if(GameControl.lost != false)
        {
            gameObject.SetActive(false);
        }
    }
}
