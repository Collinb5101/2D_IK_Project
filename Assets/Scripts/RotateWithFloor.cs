using UnityEngine;

public class RotateWithFloor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 100);

        if (hit)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.Cross(transform.TransformDirection(Vector2.up), hit.normal));
        }
    }
}
