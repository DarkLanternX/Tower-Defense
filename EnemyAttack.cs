using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float timer;
    public GameObject firePoint;
    [SerializeField] GameObject bullet;
    private Rigidbody2D rb;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = bullet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            shoot(PoolObjectType.EnemyBullet);

        }

    }

    void shoot(PoolObjectType type)
    {
        GameObject bullet = PoolManager.Instance.GetPoolObject(type);
        if (bullet != null)
        {
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = Quaternion.Euler(0, 180, 0);
            bullet.SetActive(true);

        }

    }
}
