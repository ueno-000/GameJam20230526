using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class EnemyBoss : MonoBehaviour,IDamage
{
    // Start is called before the first frame update
    Rigidbody2D _rd;

    public int _speed;

    public int timeOut;

    public float HP;

    public float MaxHP;

    public int _move;

    bool b = false;

    [SerializeField] GameObject _bullet;

    //[SerializeField] Slider HPbar;

    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        StartCoroutine(Randam2());

        
    }

    // Update is called once per frame
    void Update()
    {
        //if (_move == 1)
        //{
        //    transform.position -= new Vector3(Time.deltaTime * _speed, 0);
        //    b = true;
        //}
        //else if (_move == 0) 
        //{
        //    transform.position += new Vector3(Time.deltaTime * _speed, 0);
        //    b = true;
        //}
        //else
        //{
        //           Attack();
        //    Debug.Log(_move);
        //}

        if(HP <= 0)
        {

            GameManager.GetClear = true;
            Destroy(this.gameObject);

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

    void Attack()
    {
        
        if (b == true) 
        {
            GameObject game = Instantiate(_bullet, transform.position, transform.rotation);
            b = false;
        }
        
    }

    void IDamage.Damage(float damage)
    {
        Debug.Log("aaaaa");
        HP -= damage;
        //HPbar.value = HP / MaxHP;
    }
}
