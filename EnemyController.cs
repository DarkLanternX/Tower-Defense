using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float lookRadius = 15f;
    private Rigidbody2D rb;
    [SerializeField] GameObject target;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        Vector2 pos = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        rb.MovePosition(pos);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }
}


