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

    int explosionAmount;

    private void Awake()
    {
        explosionAmount = 3;
        explodeText.text = "x " + explosionAmount;
        if (StartGame.shootTime != true)
        {
            explodeButton.interactable = false;
        }
    }

    private void Update()
    {
        
        explodeText.text = "x " + explosionAmount;
        if(explosionAmount < 1 || StartGame.shootTime != true || GameControl.lost == true)
        {
            explodeButton.interactable = false;
        }
        else
        {
            explodeButton.interactable = true;

        }
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
        }
    }
}
