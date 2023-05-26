using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestnut : MonoBehaviour
{
    public int AddHP;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IItim _hp = collision.gameObject.GetComponent<IItim>();
            _hp.HP(AddHP);
            Destroy(this.gameObject);
        }

    }
}
