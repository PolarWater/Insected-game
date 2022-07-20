using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }

    }


    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        animator.SetTrigger("deathEffect");
        Destroy(gameObject);

        
    }
}
