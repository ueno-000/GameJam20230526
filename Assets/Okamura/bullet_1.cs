using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_1 : MonoBehaviour
{
    Transform _tr;
    Rigidbody2D _rb;
    [SerializeField] GameObject Player;
    public int Bulletspeed1_; 
    public float _damage1;
    [SerializeField] float Reloadtime;
    float time;
    // Start is called  the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        _rb.AddForce (new Vector3 (0, -1 * Bulletspeed1_, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IDamage damage3 = collision.gameObject.GetComponent<IDamage>();
            damage3.Damage(_damage1);
        }
    }
}
