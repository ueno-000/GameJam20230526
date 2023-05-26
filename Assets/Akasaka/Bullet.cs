using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rd;

    [SerializeField] GameObject Player;

    Transform bullet;

    private int timeOut;

    public float time;

    public int bulletSpeed;

    public float damage;

    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;
        if (time < 3)
        {
            Vector3 vector3 = Player.transform.position - bullet.position;
            _rd.AddForce(vector3.normalized * bulletSpeed);
            _rd.AddForce(vector3 * bulletSpeed);  
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            IDamage dd = collision.gameObject.GetComponent<IDamage>();
            dd.Damage(damage);
        }
    }
}
