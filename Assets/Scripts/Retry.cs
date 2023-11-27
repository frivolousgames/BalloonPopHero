using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject buyScreen;

    public void ReloadLevel()
    {
        StartCoroutine("RetryWait");
        //buyScreen.SetActive(false);
    }

    IEnumerator RetryWait()
    {
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene("Level_01");
    }
}
