using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadSound : MonoBehaviour
{
    public GameObject reloadSound;

    public void SpawnReloadSound()
    {
        Instantiate(reloadSound, null);
    }
}
