using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public GameObject popSound;
    public GameObject swellSound;
    public GameObject introSong;

    public void Pop()
    {
        Instantiate(popSound, null);
    }

    public void Swell()
    {
        Instantiate(swellSound, null);
    }

    public void KillIntroSong()
    {
        introSong.SetActive(false);
    }
}
