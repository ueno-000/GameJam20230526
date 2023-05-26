using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rd;

    public int _speed;

    [SerializeField] GameObject _bullet;

    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        GameObject game = Instantiate(_bullet, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * _speed, 0);   
    }
}
