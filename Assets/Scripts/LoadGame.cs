using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    

    public void LoadPlayLevel()
    {
        SceneManager.LoadScene("Level_01");
        SceneManager.LoadScene("Demo", LoadSceneMode.Additive);
    }
}
