﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza_attack : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("yoda"))
       {
           Destroy(other.gameObject);
           Destroy(this.gameObject);
       }
    }

}
