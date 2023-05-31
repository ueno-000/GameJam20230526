using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    Rigidbody2D _rb;
    //[SerializeField] GameObject Player;
    public int Bulletspeed1_; 
    public float _damage1;
    [SerializeField] float Reloadtime;
    //float time;
    // Start is called  the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
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
            var damage = collision.gameObject.GetComponent<IDamage>();
            damage.Damage(_damage1);
            Destroy(this.gameObject);
        }
    }
}
