using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        //adjust health
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        //set health on the slider
        slider.value = health;
    }
}
