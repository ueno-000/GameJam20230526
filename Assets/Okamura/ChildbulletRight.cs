using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildbulletRight : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject R_muzzle;
    Rigidbody2D _rb;
    Transform _tr;
    [SerializeField] float proceedspeed;
    bool _isActive = true;
    [SerializeField] float reaned;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActive)
        {
            Vector3 vector3 = R_muzzle.transform.position + _tr.position;
            _rb.AddForce(vector3.normalized * proceedspeed);
            _isActive = false;
        }
    }
}
