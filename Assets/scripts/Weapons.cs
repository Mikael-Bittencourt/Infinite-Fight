using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
     
     public Transform firePoint;
     public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
     {
        Shoot();
     }
    }

    void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
