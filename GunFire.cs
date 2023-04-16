using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GunFire : MonoBehaviour
{

    public ParticleSystem flash;
    public Transform firePoint;
    //public AudioClip shoot;
    public float damage;
    public float range;
    public GameObject explode;
    [SerializeField] GameObject gm;



    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fx();
            Shoot(PoolObjectType.Bullet);
        }
    }

    public void fx()
    {
        flash.Play();
        //AudioSource.PlayClipAtPoint(shoot, transform.position, 1);
    }

    public void Shoot(PoolObjectType type)
    {
        GameObject bullet = PoolManager.Instance.GetPoolObject(type);   //Projectile shoot
        if (bullet != null) 
        {
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
            bullet.SetActive(true);

        }

       /* RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.up);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 20f, Color.green); //Raycast shoot
        
        {
            

        }*/
    }
}

      
    