using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    Rigidbody2D _rb2;
    [SerializeField] GameObject _bullet3;
    
    [Header("Enemy speed")]public int speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
        GameObject bulletspawn_ = Instantiate(_bullet3, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,Time.deltaTime *  speed);
    }
}