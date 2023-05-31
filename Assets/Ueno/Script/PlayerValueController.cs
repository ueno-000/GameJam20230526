using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Playerの各種値
/// </summary>
public class PlayerValueController : MonoBehaviour,IDamage,IItim
{
    /// <summary>スライダー</summary>
    [SerializeField] private Slider _heathSlider;

    /// <summary>無敵時間 </summary>
    [SerializeField] private float _invincibleTime = 5;
    /// <summary> 無敵モードフラグ</summary>
    private bool _isInvincible;

    /// <summary>プレイヤーMax体力 </summary>
    [SerializeField] private float _maxHealth = 1000;

    private Animator _anim;
    private float time;

    /// <summary>スコア</summary>
    private int _score = 0;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
        }
    }

    private float _health = 100;
    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

   
    [SerializeField]private float _speed = 20;
    public float PlayerSpeed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    private bool _isSpeedUP;
    public bool IsSpeedUP
    {
        get
        {
            return _isSpeedUP;
        }
        set
        { 
            _isSpeedUP = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Health = _maxHealth;
  
        _heathSlider = _heathSlider.gameObject.GetComponent<Slider>();
        _heathSlider.maxValue = _maxHealth;
        _heathSlider.value = _maxHealth;
        
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {
        Score++;
        
        _heathSlider.value = _health;

        if (_health <= 0)
        {
            GameManager.GameOver = true;

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Muteki();
    }

    /// <summary>
    /// 無敵モード
    /// </summary>
    void Muteki()
    {
        if (_isInvincible)
        {
            Debug.Log("無敵モード開始");
            time += Time.deltaTime;

            _anim.SetBool("isMuteki", true);

            if (time >= _invincibleTime)
            {
                Debug.Log("無敵モード終了");
                time = 0;
                _isInvincible = false;
                _anim.SetBool("isMuteki", false);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Usu")
        {
            _isInvincible = true;
        }
    }

    public void Damage(float damage)
    {
        if (!_isInvincible)
        {
            Health -= damage;
        }
        _anim.SetTrigger("DamageTrigger");
    }

    public void HP(float _AddHP)
    {
        Health += _AddHP;
    }

    public void Speed(float spe)
    {
        IsSpeedUP = true;
        PlayerSpeed += spe;
    }
}

