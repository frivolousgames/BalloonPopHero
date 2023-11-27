using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBuyScreen : MonoBehaviour
{
    public GameObject buyScreen;
    public GameObject endScreen;

    public void ActivateBuyScreen()
    {
        buyScreen.SetActive(true);
        endScreen.SetActive(false);
    }
}
