using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _damagePower;
    [SerializeField] private float _destroyTime = 5f;
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = this.transform.up * _speed;
        Destroy(this.gameObject, _destroyTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var damagetarget = collision.gameObject.GetComponent<IDamage>();
        //IDamagable ÇÕ AddDamage ÇÃèàóùÇ™ïKê{
        if (damagetarget != null)
        {
            collision.gameObject.GetComponent<IDamage>().Damage(_damagePower);
        }
        Destroy(this.gameObject);
    }

}
