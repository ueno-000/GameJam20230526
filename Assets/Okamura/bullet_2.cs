using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_2 : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float _damage2;
    Rigidbody2D _rb;
    Transform _tr;
    [SerializeField] GameObject ChildBulletleft;
    [SerializeField] GameObject ChildBulletright;
    [SerializeField] float BulletSpeed;
    float ProceedTime;
    [SerializeField] float BurstTime;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * BulletSpeed);
        ProceedTime += Time.deltaTime;
        if (ProceedTime >= BurstTime)
        {
            Instantiate(ChildBulletleft, transform.position, transform.rotation);
            Instantiate(ChildBulletright, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IDamage damage3 = collision.gameObject.GetComponent<IDamage>();
            damage3.Damage(_damage2);
        }
    }
}
