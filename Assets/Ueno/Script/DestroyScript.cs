using UnityEngine;

/// <summary>
/// �G�ꂽ���̂��ׂĂ�j�󂷂�script
/// </summary>
public class DestroyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
