using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    public Slider slider2;

    public void SetMaxHealth(int health)
    {
        slider2.maxValue = health;
        slider2.value = health;
    }

    // Start is called before the first frame update
    public void SetHealth(float health)
    {
        slider2.value = health;
    }

    public void TakeDamage(float damage)
    {
        slider2.value -= damage;
        SetHealth(slider2.value);
    }

}

