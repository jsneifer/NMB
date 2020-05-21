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
    public void SetHealth(int health)
    {
        slider2.value = health;
    }

    //public void TakeDamage(float damage)
    //{
    //_currentHealth -= damage;
    //HealthBar.value = _currentHealth;
    //}

}

