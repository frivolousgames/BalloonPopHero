using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAudio : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetFloat("Volume", 1);
    }


    public void ToggleAudioImage()
    {
        if(AudioListener.volume > .5)
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetFloat("Volume", 0);
        }
        else
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetFloat("Volume", 1);
        }
    }

    
}
