using UnityEngine;

public class StayUpright : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.LookRotation(Vector2.up, Vector2.left);
    }
}
