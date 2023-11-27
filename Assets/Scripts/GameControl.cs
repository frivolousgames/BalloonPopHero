using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Slider ozoneSlider;

    public static bool lost;

    GameObject[] balloons;

    public GameObject endScreen;

    public static int shieldLevel;
    public static int bonusLevel;

    public static int bonus;

    private void Awake()
    {
        lost = false;
        ScoreController.score = 0;
        shieldLevel = 0;
        bonusLevel = 1;
        bonus = 0;
    }

    private void Update()
    {
        balloons = GameObject.FindGameObjectsWithTag("Balloon");

        if(ozoneSlider.value < 1)
        {
            lost = true;
            if(balloons != null)
            {
                foreach(GameObject balloon in balloons)
                {
                    Destroy(balloon);
                }
            }
        }
        //Debug.Log("Bonus " + bonus);

        if(lost == true)
        {
            if(endScreen.activeInHierarchy != true)
            {
                endScreen.SetActive(true);
            }
        }
    }
}
