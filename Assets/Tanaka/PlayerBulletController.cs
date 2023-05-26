using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
   
    [Header("アタッチするもの")]
    [Tooltip("牡蠣のプレハブを入れる"),SerializeField] private GameObject _bulletPrefab;
    [Tooltip("球を発射する位置のGameObjectを入れる"), SerializeField] private Transform _muzzlePos;
    [Tooltip("打った時の効果音"), SerializeField] private AudioClip _bulletSE;

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
