using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{

    [Header("アタッチするもの")]
    [Tooltip("牡蠣のプレハブを入れる"), SerializeField] private GameObject _bulletPrefab;
    [Tooltip("球を発射する位置のGameObjectを入れる"), SerializeField] private Transform _muzzlePos;
    [Tooltip("打った時の効果音"), SerializeField] private AudioClip _bulletSE;

    [Header("各種値変更")]
    /// <summary>
    /// 打てる間隔
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
