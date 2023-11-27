using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPowerUp : MonoBehaviour
{

    public GameObject amountTrail;
    Text amountText;
    List<string> puTypesArray;
    public List<string> puTypes;
    int i;

    public static string selectedPU;
    int puAmount;
    Slider ozoneSlider;
    public GameObject ozoneBlink;
    Transform ozoneBlinkSpawn;
    Transform canvas;

    public GameObject bonusBlink;
    Transform bonusBlinkSpawn;

    public GameObject shieldBlink;
    Transform shieldBlinkSpawn;

    Text levelText;
    Text bonusText;

    private void Awake()
    {
        levelText = GameObject.FindGameObjectWithTag("LevelText").GetComponent<Text>();
        bonusText = GameObject.FindGameObjectWithTag("BonusText").GetComponent<Text>();

        puTypesArray = new List<string>();
        ozoneSlider = GameObject.FindGameObjectWithTag("OzoneSlider").GetComponent<Slider>();
        ozoneBlinkSpawn = GameObject.FindGameObjectWithTag("SliderBlinkSpawn").transform;
        canvas = GameObject.FindGameObjectWithTag("Canvas").transform;

        bonusBlinkSpawn = GameObject.FindGameObjectWithTag("BonusBlink").transform;
        shieldBlinkSpawn = GameObject.FindGameObjectWithTag("ShieldBlink").transform;

        //BulletManager.bulletAmount += 5;
        foreach (string pu in puTypes)
        {
            if (pu != selectedPU)
            {
                puTypesArray.Add(pu);
            }
        }
        
    }
    private void Start()
    {
        i = Random.Range(0, puTypesArray.Count);
        selectedPU = puTypesArray[i];
        amountText = amountTrail.GetComponentInChildren<Text>();
        switch (selectedPU)
        {
            case "Ammo":
                BulletCounter.puSum += 5;
                BulletCounter.bullets = 10 + BulletCounter.puSum;
                BulletCounter.bulletMax = 10 + BulletCounter.puSum;
                puAmount = 5;
                break;
            case "Bonus":
                GameControl.bonusLevel++;
                Instantiate(bonusBlink, bonusBlinkSpawn.position, Quaternion.identity, canvas);
                bonusText.text = "x" + GameControl.bonusLevel.ToString();
                puAmount = 1;
                break;
            case "Shield":
                Instantiate(ozoneBlink, ozoneBlinkSpawn.position, Quaternion.identity, canvas);
                Instantiate(shieldBlink, shieldBlinkSpawn.position, Quaternion.identity, canvas);
                GameControl.shieldLevel++;
                levelText.text = "LV. " + GameControl.shieldLevel.ToString();
                ozoneSlider.maxValue += 5;
                ozoneSlider.value = ozoneSlider.maxValue;
                puAmount = 1;
                break;
        }
        amountText.text = "+  " + puAmount + "  " + selectedPU;
        Instantiate(amountTrail, transform.position, Quaternion.identity, null);
        
        //StartCoroutine("ResetDefaultAmmo");
    }

}
