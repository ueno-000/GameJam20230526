using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptTest : MonoBehaviour
{
    [SerializeField] private float _destroyTime = 5f;
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = this.transform.up * _speed;
        Destroy(this.gameObject, _destroyTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
