using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplodeButton : MonoBehaviour
{
    public GameObject explodeCollider;
    public GameObject explodeSound;

    public Button explodeButton;
    public Text explodeText;

    public static int explosionAmount;

    private void Awake()
    {
        explosionAmount = PlayerPrefs.GetInt("ExploderAmount", 3);
        explodeText.text = "x " + explosionAmount;
        if (StartGame.shootTime != true)
        {
            explodeButton.interactable = false;
        }
    }

    private void Update()
    {
        explosionAmount = PlayerPrefs.GetInt("ExploderAmount", 3);
        explodeText.text = "x " + explosionAmount;
        if(explosionAmount < 1 || StartGame.shootTime != true || GameControl.lost == true)
        {
            explodeButton.interactable = false;
        }
        else
        {
            explodeButton.interactable = true;

        }
        //Debug.Log("Exploders " + PlayerPrefs.GetInt("ExploderAmount", 3));
    }

    public void DestroyBalloons()
    {
        if(explodeButton.interactable == true)
        {
            Instantiate(explodeCollider, null);
            Instantiate(explodeSound, null);
            if (explosionAmount > 0)
            {
                explosionAmount--;
            }
            PlayerPrefs.SetInt("ExploderAmount", explosionAmount);
        }
    }
}
