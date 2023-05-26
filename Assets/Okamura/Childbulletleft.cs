using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Childbulletleft : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float _damage2cl;
    [SerializeField] GameObject Spawnposition;
    [SerializeField] GameObject L_muzzle;
    Rigidbody2D _rb;
    [SerializeField] float proceedspeed;
    bool _isActive = true;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        for(i=0;i<1;i++)
        {
            Vector3 vector3 = L_muzzle.transform.position - Spawnposition.transform.position;
            _rb.AddForce(proceedspeed * vector3.normalized);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            IDamage damage3 = collision.gameObject.GetComponent<IDamage>();
            damage3.Damage(_damage2cl) ;
        }
    }
}
