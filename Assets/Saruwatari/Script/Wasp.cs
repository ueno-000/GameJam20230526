using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasp : MonoBehaviour
{
    public int AddSpeed;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IItim Spe = collision.gameObject.GetComponent<IItim>();
            Spe.Speed(AddSpeed);
            Destroy(this.gameObject);
        }
        
    }
}
