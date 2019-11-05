using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void ReloadLevel()
    {
        StartCoroutine("RetryWait");
    }

    IEnumerator RetryWait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level_01");
    }
}
