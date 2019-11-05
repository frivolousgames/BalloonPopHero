using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    //Animator anim;
    public static int bullets;

    public static int puSum;

    public Button reloadButton;

    public Text bulletAmountText;

    public static int bulletMax;

    //public GameObject actionObject;
    //Text actionText;
    //public GameObject canvas;
    //public GameObject actionSpawn;
    public GameObject reloadText;

    private void Awake()
    {
        bullets = 10;
        bulletMax = 10;
    }

    private void OnEnable()
    {
        bullets = 10 + puSum;
        bulletMax = 10 + puSum;
    }
    
    private void Update()
    {
        bulletAmountText.text = bullets.ToString() + "/" + bulletMax;
        if(bullets < 1)
        {
            //anim.SetTrigger("Reload");
            reloadButton.interactable = true;
            reloadText.SetActive(true);
            
            gameObject.SetActive(false);
        }

    }

    
    
}
