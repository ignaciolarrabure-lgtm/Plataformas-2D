using Unity.VisualScripting;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

  private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el obstáculo toca al jugador (que tiene este script de Game_Controller)
        if (collision.CompareTag("Obstacle")) 
        {
            // Buscamos el script de movimiento y llamamos a Die()
            GetComponent<Player_Movement>().Die();
        }
    }
   

}

