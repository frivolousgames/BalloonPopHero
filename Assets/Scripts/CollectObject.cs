using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    public GameObject amountTrail;
    Text amountText;
    List<string> ammoTypesArray;
    public List<string> ammoTypes;
    int i;

    string selectedAmmo;
    int ammoAmount;

    GameObject prefabTrail;

    //bool powerUpTime;

    //int waitTime = 20;

    private void Awake()
    {
        ammoTypesArray = new List<string>();
        foreach(string ammo in ammoTypes)
        {
            
            if(ammo != SpawnBullet.bulletType)
            {
                if(ScoreController.powerUpTime != true)
                {
                    if(ammo == "Spray" || ammo == "Wave")
                    {
                        
                    }
                    else
                    {
                        ammoTypesArray.Add(ammo);
                    }
                }
                else
                {
                    if (/*ammo == "Laser" || */ammo == "Explode")
                    {

                    }
                    else
                    {
                        ammoTypesArray.Add(ammo);
                    }
                }
            }
        }
        i = Random.Range(0, ammoTypesArray.Count);
        selectedAmmo = ammoTypesArray[i];
        
    }
    private void Start()
    {
        SpawnBullet.bulletType = selectedAmmo;
        
        prefabTrail = Instantiate(amountTrail, transform.position, Quaternion.identity, null);
        amountText = prefabTrail.GetComponentInChildren<Text>();
        amountText.text = "+  " + selectedAmmo;
        //StartCoroutine("ResetDefaultAmmo");
    }
    private void Update()
    {
        //powerUpTime = 
    }

}
