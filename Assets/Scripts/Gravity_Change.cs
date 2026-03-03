using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class Gravity_Change : MonoBehaviour
{
    private Rigidbody2D Player_Rig;


    private void Awake()
    {
        Player_Rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        Gravity_Swap();

    }

    private void Gravity_Swap()
    {
        if (Input.GetKeyDown(KeyCode.E) && Ground_Checker.Is_Grounded)
        {
            Player_Rig.gravityScale *= -1;

            transform.Rotate(180,0,0);
        }
       
    }
}
