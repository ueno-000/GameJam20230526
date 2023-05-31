using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSpownScript : MonoBehaviour
{
    [Header("アタッチするもの")]
    /// <summary>BossObjPrefab</summary>
    [SerializeField] GameObject _bossPrefab;
    [SerializeField] AudioClip _bossBGM;
    [SerializeField] GameObject _bossTextUI;
    [SerializeField] private Text _countDawnText;

    [Header("各種設定値")]
    /// <summary>Bossがスポーンする時間</summary>
    [Tooltip("スポーンの時間を設定する"),SerializeField] private float _spawnTime;
    /// <summary>Bossがスポーンする位置</summary>
    [Tooltip("スポーンの位置を設定する"), SerializeField] Transform _spawnPoint;

    private float _time;
    private bool _isAppearBoss;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _countDawnText = _countDawnText.gameObject.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    /// <summary>
    /// 時間が来たら一回だけBossを生成する
    /// </summary>
    private void Spawn()
    {
        var isCount = false;

        if (!isCount)
        {
            _time += Time.deltaTime;
        }

        if (_time < _spawnTime)
        {
            var count = _spawnTime - _time;
            count = Mathf.Floor(count);
            _countDawnText.text = count.ToString();
            isCount = true;
        }
        else 
        {
            _countDawnText.text = "0";
        }


        if (_spawnTime < _time && !_isAppearBoss)
        {
            Director();

            _isAppearBoss = true;
            Instantiate(_bossPrefab, _spawnPoint.position, Quaternion.identity);
        }
    }

    /// <summary>
    /// 演出
    /// </summary>
    private void Director()
    {
        _audioSource.clip = _bossBGM;
        _audioSource.Play();
        _bossTextUI.SetActive(true);
    }
}
