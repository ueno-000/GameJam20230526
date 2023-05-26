using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
   
    [Header("�A�^�b�`�������")]
    [Tooltip("���y�̃v���n�u������"),SerializeField] private GameObject _bulletPrefab;
    [Tooltip("���𔭎˂���ʒu��GameObject������"), SerializeField] private Transform _muzzlePos;
    [Tooltip("�ł������̌��ʉ�"), SerializeField] private AudioClip _bulletSE;

    private AudioSource _audio;

      void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_bulletPrefab,_muzzlePos.position,Quaternion.identity);
            _audio.PlayOneShot(_bulletSE);
        }

    }
}
