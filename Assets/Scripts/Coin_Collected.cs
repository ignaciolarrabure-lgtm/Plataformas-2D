using UnityEngine;

public class Coin_Collected : MonoBehaviour
{

    public int value;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Coin_Counter.instance.Increase_Coins(value);

            Debug.Log("Coin collected");
        }

    }
}
