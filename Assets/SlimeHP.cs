using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHP : MonoBehaviour
{
    public float health = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void damage(float dmgamount) 
    {
        Debug.Log("hit");
        health -= dmgamount;
        
    }
}
