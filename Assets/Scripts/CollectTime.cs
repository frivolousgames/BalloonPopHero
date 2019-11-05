using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTime : MonoBehaviour
{
    
    public int extraOzone;
    public GameObject amountTrail;
    Text amountText;
    Slider ozoneSlider;
   

    private void Awake()
    {
        amountText = amountTrail.GetComponentInChildren<Text>();
        ozoneSlider = GameObject.FindGameObjectWithTag("OzoneSlider").GetComponent<Slider>();
    }
    private void Start()
    {
        //GameTimer.time += extraTime;
        ozoneSlider.value += extraOzone;
        amountText.text = "+   " + extraOzone.ToString() + "   Ozone";
        Instantiate(amountTrail, transform.position, Quaternion.identity, null);
        //StartCoroutine("MoneyDestroy");

    }

    private void Update()
    {
        //Debug.Log("Value " + extraTime);
    }


   
            

    IEnumerator MoneyDestroy()
    {

        yield return new WaitForSeconds(.1f);
        Destroy(gameObject);
    }
}
