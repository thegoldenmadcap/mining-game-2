using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAI : MonoBehaviour
{
    public GameObject Player;
    public float jumpTimer;
    public Rigidbody rb;
    public int jumpheight = 1;
    public int movespeed =1;
    public int attack = 1;
    public float dmgtimer = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpTimer < 2f) 
        {  
            jumpTimer += Time.deltaTime; 
        }

        if (jumpTimer >= 2f) 
        {
            Debug.Log("jump");
            rb.AddForce(0, jumpheight, 0);
            rb.AddForce (transform.forward * movespeed);
            jumpTimer = 0f;
            

        }

    }

    private void FixedUpdate()
    {
        dmgtimer += Time.deltaTime;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && dmgtimer > .5) 
        {
            HealthandDamage pDamage = Player.GetComponent<HealthandDamage>();
            pDamage.takeDamage(attack);
            Debug.Log("player is hit!");
            dmgtimer = 0f;
        }
    }
}
