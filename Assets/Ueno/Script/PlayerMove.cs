using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    ///ÉvÉåÉCÉÑÅ[ÇÃë¨Ç≥ 
    ///</summary>
    [SerializeField] private float _speed;


    private Rigidbody2D _rb;

    private float _h;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_h * _speed * Vector2.right);
    }
}
