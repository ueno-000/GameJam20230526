using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_3 : MonoBehaviour
{
    Transform _tr;
    Rigidbody2D _rb;
    [SerializeField] GameObject Player;
    public int Bulletspeed1_;
    float ChasedTime;
    [SerializeField] int ChasedTimeLimid;
    [SerializeField] int ResetTime;
    public float _damage3;
    // Start is called  the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()
    {
        ChasedTime += Time.deltaTime;
        if (ChasedTime <= ChasedTimeLimid)
        {
            Vector3 vector3 = Player.transform.position - _tr.position;
            _rb.AddForce(vector3.normalized * Bulletspeed1_);
        }
        else if (ChasedTime > ResetTime)
        {
            ChasedTime = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Player) 
        {
            IDamage damage3 = collision.gameObject.GetComponent<IDamage>();
            damage3.Damage(_damage3);
        }
    }
}
