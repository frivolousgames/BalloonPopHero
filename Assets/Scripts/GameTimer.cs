using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    Text timerText;
    public static float time;
    int actualTime;

    public static bool lost;

    private void Awake()
    {
        time = 31;
        timerText = GetComponent<Text>();
    }

    private void Update()
    {
        time -= 1 * Time.deltaTime;
        actualTime = (int)time;
        if (actualTime > 0)
        {
            timerText.text = actualTime.ToString();
            lost = false;
        }
        else
        {
            timerText.text = "TIME UP";
            lost = true;
        }

        
    }

}
