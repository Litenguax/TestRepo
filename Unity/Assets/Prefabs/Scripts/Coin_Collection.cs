using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // This is called when another object enters the coin's trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");
        }
    }
}
