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
    [Header("アタッチするもの")]
    /// <summary>
    /// Bossが生成するBullet
    /// </summary>
    [SerializeField] GameObject _bulletPrefab;
    [Tooltip("HPSliderをアタッチする"), SerializeField] Slider _bossHpSlider;
    [Tooltip("ゴリラがダメージを受けたSEをアタッチする"),SerializeField] private AudioClip _damageSE;

    [Header("各種設定値")]
    [Tooltip("Enemyの移動速度"),Range(1,10),SerializeField] private float _speed;
    [Tooltip("攻撃のインターバル"), Range(1, 10), SerializeField] private float _attackInterval = 3f;
    [Range(1, 500), SerializeField] private float _maxHP = 250;
    [Tooltip("Enemyの横移動可能範囲のX軸絶対値"), Range(5, 20), SerializeField] private float _moveEnabledPosX = 10;

    private Animator _anim;
    private AudioSource _audio;

    /// <summary>Enemyの行動を決める値</summary>
    private int _actionNum;
    /// <summary>Enemyの体力</summary>
    private float _currentHp;
    /// <summary>攻撃が出来るかの判定</summary>
    private bool _isAttack = false;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();

        /*HP関連の初期化
        Enemy頭上のHPバーと実際の保持しているHPの値、最大HPが
        バラバラにならないようにしている
         */
        _bossHpSlider = _bossHpSlider.gameObject.GetComponent<Slider>();
        _bossHpSlider.maxValue = _maxHP;
        _bossHpSlider.value = _maxHP;
        _currentHp = _maxHP;


        StartCoroutine(BossAction());

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"ボスHP：{_currentHp}");

        if (_actionNum == 1)//左移動
        {
            if (transform.position.x > -_moveEnabledPosX)//移動可能範囲内で動く
            {
                transform.position -= new Vector3(Time.deltaTime * _speed, 0);
                _isAttack = true;
            }
        }
        else if (_actionNum == 0)//右移動
        {
            if (transform.position.x < _moveEnabledPosX)
            {
                transform.position += new Vector3(Time.deltaTime * _speed, 0);
                _isAttack = true;
            }
        }
        else
        {
            Attack();
            Debug.Log(_actionNum);
        }

        if (_currentHp <= 0)
        {
            GameManager.GetClear = true;
            Destroy(this.gameObject);
        }
    }


    private IEnumerator BossAction()
    {
        while (true)
        {
            _actionNum = Random.Range(0,3);
            yield return new WaitForSeconds(_attackInterval);
            Instantiate(_bulletPrefab, transform.position, transform.rotation);
        }
    }

    private void Attack()
    {
        
        if (_isAttack == true) 
        {
            Instantiate(_bulletPrefab, transform.position, transform.rotation);
            _isAttack = false;
        }
        
    }

    void IDamage.Damage(float damage)
    {
        _currentHp -= damage;
        _bossHpSlider.value = _currentHp;
        _anim.SetTrigger("DamageTrigger");
        _audio.PlayOneShot(_damageSE);
        //Debug.LogAssertion($"ボスHP：{_currentHp}");
    }
}
