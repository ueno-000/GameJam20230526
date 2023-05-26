using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{

    [Header("�A�^�b�`�������")]
    [Tooltip("���y�̃v���n�u������"), SerializeField] private GameObject _bulletPrefab;
    [Tooltip("���𔭎˂���ʒu��GameObject������"), SerializeField] private Transform _muzzlePos;
    [Tooltip("�ł������̌��ʉ�"), SerializeField] private AudioClip _bulletSE;

    [Header("�e��l�ύX")]
    /// <summary>
    /// �łĂ�Ԋu
    /// </summary>
    [SerializeField] private float _coolTime;
    private bool isBullet = true;
    private AudioSource _audio;
    private float _time;
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        isBullet = true;
    }


    void Update()
    {
        if (isBullet && Input.GetButtonDown("Fire1"))
        {
            isBullet = false;
            Instantiate(_bulletPrefab, _muzzlePos.position, Quaternion.identity);
            _audio.PlayOneShot(_bulletSE);
        }
        if (_time <= _coolTime)
        {
            _time += Time.deltaTime;
        }
        else
        {
            _time = 0;
            isBullet = true;
        }

    }
}
