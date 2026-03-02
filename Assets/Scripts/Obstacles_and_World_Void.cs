using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Player_Movement>())
        {
            collision.collider.GetComponent<Player_Movement>().Die();
        }
    }
}
