using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewGame : MonoBehaviour
{
    public Animator anim;

    public void NewGame()
    {
        anim.SetTrigger("Start");
    }

}
