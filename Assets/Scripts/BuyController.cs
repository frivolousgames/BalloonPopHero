using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class BuyController : MonoBehaviour
{
    public GameObject confirmScreen;

    public static string buttonID;
    int exploderAmount;
    public GameObject confirmButton;
    CodelessIAPButton buyButton;

    public GameObject passFailScreen;
    public Text passFailText;

    public Text exploderText;

    private void Awake()
    {
        buyButton = confirmButton.GetComponent<CodelessIAPButton>();
    }

    private void Update()
    {
        buyButton.productId = buttonID;
    }

    public void Button_8()
    {
        buttonID = "exploder_8";
        exploderAmount = 8;
        confirmScreen.SetActive(true);
    }
    public void Button_20()
    {
        buttonID = "exploder_20";
        exploderAmount = 20;
        confirmScreen.SetActive(true);
    }
    public void Button_100()
    {
        buttonID = "exploder_100";
        exploderAmount = 100;
        confirmScreen.SetActive(true);
    }
    public void OnComplete()
    {
        exploderAmount += ExplodeButton.explosionAmount;
        PlayerPrefs.SetInt("ExploderAmount", exploderAmount);
        passFailScreen.SetActive(true);
        passFailText.text = "SUCCESS!";
    }
    public void OnFail()
    {
        passFailScreen.SetActive(true);
        passFailText.text = "FAILED!";
    }

    public void CloseConfirmScreen()
    {
        confirmScreen.SetActive(false);
    }
    public void ClosePassFailScreen()
    {
        passFailScreen.SetActive(false);
    }
}
