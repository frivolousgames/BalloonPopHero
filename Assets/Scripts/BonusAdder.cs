using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusAdder : MonoBehaviour
{
    public float waitTime;
    public int value;

    GameObject prefabTrail;
    public GameObject amountTrail;
    public GameObject bonusSound;
    Text amountText;

    private void Awake()
    {
        GameControl.bonus++;
        StartCoroutine("ResetBonus");
        if (GameControl.bonus > 1)
        {
            //amountText.text = "X" + bonus;
            prefabTrail = Instantiate(amountTrail, new Vector2(transform.position.x, transform.position.y + 1f), Quaternion.identity, null);
            Instantiate(bonusSound, null);
            amountText = prefabTrail.GetComponentInChildren<Text>();
            amountText.text = "x" + GameControl.bonus;
            ScoreController.score += GameControl.bonus * value;
        }
    }
    IEnumerator ResetBonus()
    {
        yield return new WaitForSeconds(waitTime);
        if (GameControl.bonus > 0)
        {
            GameControl.bonus--;
        }
    }
    
}
