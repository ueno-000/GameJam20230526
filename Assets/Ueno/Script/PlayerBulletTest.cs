using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletTest : MonoBehaviour
{
    [Header("�A�^�b�`�������")]
    [Tooltip("���y��Prefab������"),SerializeField] private GameObject _bulletPrefab;
    [Tooltip("�e�𔭎˂���ʒu��GameObject�������"), SerializeField] private Transform _muzzlePos;
    [Tooltip("���������̌��ʉ�"), SerializeField] private AudioClip _bulletSE;

    [Header("�e��l�ύX")]
    /// <summary>
    /// ���Ԋu
    /// </summary>
    [SerializeField]private float _coolTime;
    private bool isBullet = true;

    private AudioSource _audio;
    private float _time;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        isBullet = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBullet&&Input.GetButtonDown("Fire1"))
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
