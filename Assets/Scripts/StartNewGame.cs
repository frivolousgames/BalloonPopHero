using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class StartNewGame : MonoBehaviour
{
    public Animator anim;


    private void Awake()
    {
        //Turn off Unity analytics
        Analytics.initializeOnStartup = false;
        Analytics.enabled = false;
        PerformanceReporting.enabled = false;
        Analytics.limitUserTracking = true;
        Analytics.deviceStatsEnabled = false;
    }
    public void NewGame()
    {
        anim.SetTrigger("Start");
    }

}
