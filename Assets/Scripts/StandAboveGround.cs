using UnityEngine;

public class StandAboveGround : MonoBehaviour
{
    public float distanceFromGround;
    public LayerMask ground;
    public float strength;
    public float damper;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - distanceFromGround), Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, distanceFromGround, ground);

        if(hit)
        {
            Debug.Log(transform.name + " has hit the ground");
            Vector2 springDir;
            if(transform.name == "Root")
            {
                springDir = transform.right;
            }
            else
            {
                springDir = transform.up;
            }
            
            Vector2 pointVelocity = rb.GetPointVelocity(transform.position);

            float offset = distanceFromGround - hit.distance;

            float velocity = Vector2.Dot(springDir, pointVelocity);

            float force = (offset * strength) - (velocity * damper);

            rb.AddForceAtPosition(springDir * force, transform.position);

        }
    }
}
