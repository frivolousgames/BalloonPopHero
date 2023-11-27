using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectSound : MonoBehaviour
{
    public GameObject itemSound;

    private void Awake()
    {
        Instantiate(itemSound, null);
        //StartCoroutine("SoundDelay");
    }

    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(.2f);
        Instantiate(itemSound, null);
    }
}
