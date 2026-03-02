using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Player_Speed = 0f;

    public float Jump_Force = 0f;


    Rigidbody2D rb2D;


    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    
    void Update()
    {
        
    }
}
