using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSpownScript : MonoBehaviour
{
    [Header("�A�^�b�`�������")]
    /// <summary>BossObjPrefab</summary>
    [SerializeField] GameObject _bossPrefab;
    [SerializeField] AudioClip _bossBGM;
    [SerializeField] GameObject _bossTextUI;
    [SerializeField] private Text _countDawnText;

    [Header("�e��ݒ�l")]
    /// <summary>Boss���X�|�[�����鎞��</summary>
    [Tooltip("�X�|�[���̎��Ԃ�ݒ肷��"),SerializeField] private float _spawnTime;
    /// <summary>Boss���X�|�[������ʒu</summary>
    [Tooltip("�X�|�[���̈ʒu��ݒ肷��"), SerializeField] Transform _spawnPoint;

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
    /// ���Ԃ��������񂾂�Boss�𐶐�����
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
    /// ���o
    /// </summary>
    private void Director()
    {
        _audioSource.clip = _bossBGM;
        _audioSource.Play();
        _bossTextUI.SetActive(true);
    }
}
