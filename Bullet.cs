using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    [SerializeField] int damage = 40;
    GameManager gM;
    public float score;
    public GameObject managerObj;
    public GameObject fx;
        

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gM = managerObj.GetComponent<GameManager>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
        score = gM.killcount;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHP enemy = collision.gameObject.GetComponent<EnemyHP>();
        if (collision.gameObject.tag == "Enemy")
        {
            enemy.TakeDamage(damage);
            gM.killcount++;                    
            gameObject.SetActive(false);

            

        }
        if (collision.gameObject.tag == "EMissile")
        {
            GameObject efx = Instantiate(fx, transform.position, Quaternion.identity);  //blows up enemy missile
            gameObject.SetActive(false);
            Destroy(efx, 2f);
        }

    }

   
}
