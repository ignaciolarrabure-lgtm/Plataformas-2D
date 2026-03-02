using UnityEngine;

public class Ground_Checker : MonoBehaviour
{
    public static bool Is_Grounded;



    private void OnTriggerEnter2D(Collider2D collision)
    {
       Is_Grounded = true; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Is_Grounded = false;
    }


}
