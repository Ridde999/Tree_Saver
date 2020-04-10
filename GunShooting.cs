using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    public GameObject target;
    public float damage;
    public Camera fpsCam;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo))
        {
            EnemyHealth enemyHealth = hitInfo.transform.GetComponent<EnemyHealth>(); //???? Didnt understand this part
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
                Debug.Log("hit");
            }
        }
    }
}
