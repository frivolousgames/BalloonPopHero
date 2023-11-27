using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetReloadButton : MonoBehaviour
{
    Button reloadButton;

    public Animator anim;
    bool reload = false;

    private void Awake()
    {
        reloadButton = GetComponent<Button>();
        reloadButton.interactable = false;
    }

    public void SetActive()
    {
        if(reloadButton.interactable == false)
        {
            reloadButton.interactable = true;

        }
    }
    public void Deactivate()
    {
        if (reloadButton.interactable == true)
        {
            reloadButton.interactable = false;

        }
    }

    private void Update()
    {
        anim.SetBool("Reload", reload);
        if(reloadButton.interactable == true)
        {
            reload = true;
        }
        else
        {
            reload = false;
        }
        if(GameControl.lost == true)
        {
            reloadButton.interactable = false;
        }
    }
}
