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
    [Header("�A�^�b�`�������")]
    /// <summary>
    /// Boss����������Bullet
    /// </summary>
    [SerializeField] GameObject _bulletPrefab;
    [Tooltip("HPSlider���A�^�b�`����"), SerializeField] Slider _bossHpSlider;
    [Tooltip("�S�������_���[�W���󂯂�SE���A�^�b�`����"),SerializeField] private AudioClip _damageSE;

    [Header("�e��ݒ�l")]
    [Tooltip("Enemy�̈ړ����x"),Range(1,10),SerializeField] private float _speed;
    [Tooltip("�U���̃C���^�[�o��"), Range(1, 10), SerializeField] private float _attackInterval = 3f;
    [Range(1, 500), SerializeField] private float _maxHP = 250;
    [Tooltip("Enemy�̉��ړ��\�͈͂�X����Βl"), Range(5, 20), SerializeField] private float _moveEnabledPosX = 10;

    private Animator _anim;
    private AudioSource _audio;

    /// <summary>Enemy�̍s�������߂�l</summary>
    private int _actionNum;
    /// <summary>Enemy�̗̑�</summary>
    private float _currentHp;
    /// <summary>�U�����o���邩�̔���</summary>
    private bool _isAttack = false;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();

        /*HP�֘A�̏�����
        Enemy�����HP�o�[�Ǝ��ۂ̕ێ����Ă���HP�̒l�A�ő�HP��
        �o���o���ɂȂ�Ȃ��悤�ɂ��Ă���
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
        Debug.Log($"�{�XHP�F{_currentHp}");

        if (_actionNum == 1)//���ړ�
        {
            if (transform.position.x > -_moveEnabledPosX)//�ړ��\�͈͓��œ���
            {
                transform.position -= new Vector3(Time.deltaTime * _speed, 0);
                _isAttack = true;
            }
        }
        else if (_actionNum == 0)//�E�ړ�
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
        //Debug.LogAssertion($"�{�XHP�F{_currentHp}");
    }
}
