using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour, IDamage
{
    public float Hp;
    Rigidbody2D _rb2;
    [SerializeField] GameObject _bullet1;
    [SerializeField] float _spawntime;
    float _time;

    [Header("Enemy speed")] public int speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        transform.position -= new Vector3(0, Time.deltaTime * speed);
        if(_time >= _spawntime)
        {
            GameObject bullet1 = Instantiate(_bullet1, transform.position, transform.rotation);
            _time = 0;
        }
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Damage(float damage)
    {
        Hp -= damage;
    }
}
