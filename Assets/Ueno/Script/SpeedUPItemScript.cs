using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUPItemScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            var damagetarget = collision.gameObject.GetComponent<IItim>();
            //IDamagable ‚Í AddDamage ‚Ìˆ—‚ª•K{
            if (damagetarget != null)
            {
                collision.gameObject.GetComponent<IItim>().Speed(20);
            }
            Destroy(this.gameObject);
        }
    }
}
