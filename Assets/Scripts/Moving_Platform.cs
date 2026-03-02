using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;

    public float speed = 0f;

    public bool Going;

    private void Start()
    {
        transform.position = PointA.position;
    }

    private void Update()
    {
        Vector3 Wanted_Position = Vector3.zero;

        if (Going)
        {
            Wanted_Position = PointB.position;
        }

        else
            Wanted_Position = PointA.position;

        Vector3 direction = Wanted_Position - transform.position;


        transform.position += direction.normalized * Time.deltaTime * speed;


        if (direction.magnitude < 1)
            Going = !Going;
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }

    private void OnCollisionExit2D(Collision2D Other)
    {
        Other.transform.parent = null;
    }

}
