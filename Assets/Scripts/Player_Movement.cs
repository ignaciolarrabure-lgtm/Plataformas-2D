using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Player_Speed = 0f;

    public float Jump_Force = 0f;

    Rigidbody2D rb2D;

    Vector2 Starting_Position;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    private void Awake()
    {
        Starting_Position = transform.position;
    }

    // Controles de Movimiento
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.linearVelocity = new Vector2(Player_Speed, rb2D.linearVelocity.y);
        }
     
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.linearVelocity = new Vector2(-Player_Speed, rb2D.linearVelocity.y);
        }

        else
        {
            rb2D.linearVelocity = new Vector2(0, rb2D.linearVelocity.y);

        }

        if (Input.GetKey("space") && Ground_Checker.Is_Grounded)
        {

            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, Jump_Force);

        }

    }
    
    // Función de muerte
    public void Die()
    {

        transform.position = Starting_Position;

    }
    




}
      
