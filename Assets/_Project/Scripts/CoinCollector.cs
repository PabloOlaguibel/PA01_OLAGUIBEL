using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject, destroyDelay);
        }
    }
}
