using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    Rigidbody2D _rb2;
    [SerializeField] GameObject _bullet2;

    [Header("Enemy speed")] public int speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
        GameObject bulletspawn_ = Instantiate(_bullet2, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * speed);
    }
}
