using UnityEngine;

public class RepositionLegs : MonoBehaviour
{
    public Transform limbSolverTarget;
    public float repositionDistance;
    public LayerMask ground;
    public float rayLength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();

        if(Vector2.Distance(limbSolverTarget.position, transform.position) > repositionDistance )
        {
            limbSolverTarget.position = transform.position;
        }
    }

    public void CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y+2) , Vector3.down, rayLength, ground);
        Debug.DrawLine(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2), new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2-rayLength));
        if(hit.collider != null)
        {
            Vector3 point = hit.point;
            point.y += 0.1f;
            transform.position = point;
        }
    }
}
