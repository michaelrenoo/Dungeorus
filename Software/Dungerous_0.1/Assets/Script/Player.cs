using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public HealthBar healthBar;

    public Collider2D collision;

    public GameObject gameOverMenu;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        OnTriggerEnter2D(collision);

        OnCollisionEnter2D(collision);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            //currentHealth = maxHealth;
            gameOverMenu.SetActive(true);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Healing(int damage)
    {
        currentHealth += damage;
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            TakeDamage(5);
        }
        

        if (collision.gameObject.tag.Equals("Heal"))
        {
            Healing(30);
        }

    }

    void OnCollisionEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            TakeDamage(5);
        }
        

        if (collision.gameObject.tag.Equals("Heal"))
        {
            Healing(30);
        }
    }

}
