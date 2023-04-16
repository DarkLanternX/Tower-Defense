using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHP : MonoBehaviour
{

    public int maxHealth = 50;
    public int currentHealth;
    public GameObject explode;
    public GameObject gameOver;
    [SerializeField] int damage = 10;
    public GameObject inGameUI;
    public TowerHealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EMissile")
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            GameObject fx = Instantiate(explode, transform.position, Quaternion.identity);
            other.gameObject.SetActive(false);

        }

    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            PlayerDie();
        } 
    }

    void PlayerDie()
    {
        gameOver.SetActive(true);
        inGameUI.SetActive(false);   

        Time.timeScale = 0;
        Cursor.visible = true;


    }
}
