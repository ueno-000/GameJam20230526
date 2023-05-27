using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    /// <summary>
    /// ÉvÉåÉCÉÑÅ[ÇÃë¨Ç≥
    /// </summary>
    private float _speed;

    private Rigidbody2D _rb;
    private float _h;

    [SerializeField] private PlayerValueController _valueController;
   private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _valueController= GetComponent<PlayerValueController>();
        _speed = 20;
    }

    void Update()
    {
        _h = Input.GetAxis("Horizontal");

        if (_valueController.IsSpeedUP)
        {
            _speed += _valueController.PlayerSpeed;
            _valueController.IsSpeedUP = false;
        }

    }

    private void FixedUpdate()
    {
        _rb.AddForce(_h * _speed * Vector2.right);
    }
}
