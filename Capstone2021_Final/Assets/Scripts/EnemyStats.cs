﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float dmg;

    public GameObject healthBarUI;
    public Slider slider;

    

    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update()
    {
        slider.value = CalculateHealth();
        
        if(health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if(health <=0)
        {
            Destroy(gameObject);
            //Score
            Score_System.scoreValue += 50;
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }

        
        
    }

     void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Bullet"))
        {
            Damage();
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

   void  Damage()
    {
        health = health - dmg;
    }
}
