using UnityEngine;

/// <summary>
/// 触れたものすべてを破壊するscript
/// </summary>
public class DestroyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
