using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    Player_Movement gameController;
    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Movement>();
    }

    // Activación de CheckPoint
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.Update_CheckPoint_Position(transform.position);

            Debug.Log("CheckPoint activado");

        }
    }


}
