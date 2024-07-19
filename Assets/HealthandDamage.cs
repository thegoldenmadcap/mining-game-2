using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthandDamage : MonoBehaviour
{
    public float currentHP;
    public int maxHP;
    public GameObject Health;
    public GameObject self;
    
    void Start()
    {
        healthbar hb = Health.GetComponent<healthbar>();
        currentHP = maxHP;
        hb.SetMaxHealth(maxHP);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (0 >= currentHP)
        {
           self.SetActive(false);
        }
        //currentHP -= Time.deltaTime * 5;
        healthbar hb = Health.GetComponent< healthbar>();
        hb.SetHealth(currentHP);
    }

    public void takeDamage(int damage)
    {
        currentHP -= damage;
    }
}
