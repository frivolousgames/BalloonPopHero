using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLevelText : MonoBehaviour
{
    public GameObject actionText;
    public Transform actionTextSpawn;
    public Transform canvas;
    public SpriteRenderer bg;
    bool startSpawn;
    bool endSpawn;

    public List<Color> colors;

    private void Update()
    {
        if (ScoreController.score < 501)
        {
            if(startSpawn == false && endSpawn == false)
            {
                if (ScoreController.score % 100 == 0)
                {
                    
                    startSpawn = true;
                }
            }
        }
        if(startSpawn == true)
        {
            actionText.GetComponent<Text>().text = "LEVEL  UP";
            bg.color = colors[0];
            Instantiate(actionText, actionTextSpawn.position, Quaternion.identity, canvas);
            endSpawn = true;
            startSpawn = false;
        }
        if(ScoreController.score % 100 != 0 && endSpawn == true) 
        {
            colors.Remove(colors[0]);
            endSpawn = false;
        }
    }
}
