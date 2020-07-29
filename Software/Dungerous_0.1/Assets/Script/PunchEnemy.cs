﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchEnemy : MonoBehaviour
{
    public int dmgToGive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Enemy enemyHealth;
            enemyHealth = other.gameObject.GetComponent<Enemy>();
            enemyHealth.TakeDamage(dmgToGive);
        }
    }
}
