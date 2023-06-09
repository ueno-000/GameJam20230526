using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHPItemScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            var damagetarget = collision.gameObject.GetComponent<IItim>();
            //IDamagable は AddDamage の処理が必須
            if (damagetarget != null)
            {
                collision.gameObject.GetComponent<IItim>().HP(100);
            }
            Destroy(this.gameObject);
        }
    }
}
