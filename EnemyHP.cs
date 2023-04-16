using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 10;
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        GameObject fx = Instantiate(deathEffect, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        Destroy(fx, 2f);
    }
}
        
