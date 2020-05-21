using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Start is called before the first frame update
    public void SetHealth(float health)
    {
        slider.value = health;
    }

    public void TakeDamage(float damage)
    {
        slider.value -= damage;
        SetHealth(slider.value);
    }

}
