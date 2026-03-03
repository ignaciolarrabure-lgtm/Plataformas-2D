using System.Collections;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Player_Speed = 0f;

    public float Jump_Force = 0f;

    Rigidbody2D rb2D;

    Vector2 CheckPoint_Position;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        CheckPoint_Position = transform.position;
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

            float gravityDirection = Mathf.Sign(rb2D.gravityScale);
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, Jump_Force * gravityDirection);

        }

    }

    // Función de Checkpoint
    public void Update_CheckPoint_Position(Vector2 pos)
    {
        CheckPoint_Position = pos;
    }


    public void Die() // Añadimos public para que el GameController pueda verla
    {
        // Así es como se activa un IEnumerator
        StartCoroutine(Respawn(0f));
    }

    IEnumerator Respawn(float duration)
    {
        // 1. Esperamos el tiempo que le pases (ej. 0.5 segundos)
        yield return new WaitForSeconds(duration);

        // 2. Teletransportamos al jugador
        transform.position = CheckPoint_Position;

        // 3. Opcional: Si quieres que deje de caer al aparecer
        rb2D.linearVelocity = Vector2.zero;
    }








}
      
