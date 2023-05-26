using UnityEngine;

/// <summary>
/// G‚ê‚½‚à‚Ì‚·‚×‚Ä‚ğ”j‰ó‚·‚éscript
/// </summary>
public class DestroyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
