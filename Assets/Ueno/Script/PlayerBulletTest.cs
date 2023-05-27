using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletTest : MonoBehaviour
{
    [Header("アタッチするもの")]
    [Tooltip("牡蠣のPrefabを入れる"),SerializeField] private GameObject _bulletPrefab;
    [Tooltip("弾を発射する位置のGameObjectをいれる"), SerializeField] private Transform _muzzlePos;
    [Tooltip("うった時の効果音"), SerializeField] private AudioClip _bulletSE;

    [Header("各種値変更")]
    /// <summary>
    /// 撃つ間隔
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
