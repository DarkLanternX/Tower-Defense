using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    TowerHP towerHp;
    public GameObject tower;
    public GameObject fx;
    [SerializeField] GameObject gameOver;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        towerHp = tower.GetComponent<TowerHP>();

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PMissile")
        {
            GameObject efx = Instantiate(fx, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(efx, 2f);
        }
    }
}
