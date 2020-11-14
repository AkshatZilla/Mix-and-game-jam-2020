using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed = 5f;
    public GameObject bulletPrefab;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        rb.AddForce(transform.forward * bulletSpeed);
    }
}