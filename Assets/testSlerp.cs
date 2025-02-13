using UnityEngine;

public class testSlerp : MonoBehaviour
{
    public bool startSlerp;
    public Transform endPos;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startSlerp)
        {
            rb.MovePosition(Vector3.SlerpUnclamped(transform.position, endPos.position, -0.1f));
        }
    }
}
