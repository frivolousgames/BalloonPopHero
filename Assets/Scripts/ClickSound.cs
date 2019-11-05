using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public GameObject clickSound;

    public void PlayClick()
    {
        Instantiate(clickSound, null);
    }
}
