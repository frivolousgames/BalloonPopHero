using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderColor : MonoBehaviour
{
    Slider healthSlider;
    public Image fill;

    public int threshold;

    public Color low;
    public Color high;

    public Text ozoneText;

    private void Awake()
    {
        healthSlider = GetComponent<Slider>();
        ozoneText.text = "OZONE   INTEGRITY";
    }

    private void Update()
    {
        if (healthSlider.value > threshold)
        {
            fill.color = high;
        }
        if (healthSlider.value < threshold && healthSlider.value > 0)
        {
            fill.color = low;
        }

        if (healthSlider.value < 1)
        {
            fill.color = Color.clear;
            ozoneText.text = "OZONE   DESTROYED";
        }
    }

}
