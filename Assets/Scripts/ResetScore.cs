using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public void ScoreReset()
    {
        ScoreController.score = 0;
    }
}
