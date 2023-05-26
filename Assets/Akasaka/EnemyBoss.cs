using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class EnemyBoss : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rd;

    public int _speed;

    public int timeOut;

    public int _hp;

    public int _move;

    bool b = false;

    [SerializeField] GameObject _bullet;

    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        StartCoroutine(Randam2());

        
    }

    // Update is called once per frame
    void Update()
    {
        if (_move == 1)
        {
            transform.position -= new Vector3(Time.deltaTime * _speed, 0);
            b = true;
        }
        else if (_move == 0) 
        {
            transform.position += new Vector3(Time.deltaTime * _speed, 0);
            b = true;
        }
        else
        {
            A();
            Debug.Log(_move);
        }
    }
    private IEnumerator Randam2()
    {
        while (true)
        {
            _move = Random.Range(0,3);
            yield return new WaitForSeconds(timeOut);
            GameObject game = Instantiate(_bullet, transform.position, transform.rotation);
        }
    }

    void A()
    {
        
        if (b == true) 
        {
            GameObject game = Instantiate(_bullet, transform.position, transform.rotation);
            b = false;
        }
        
    }

    
}
