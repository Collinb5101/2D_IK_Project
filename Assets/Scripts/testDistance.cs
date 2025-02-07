using UnityEngine;

public class testDistance : MonoBehaviour
{
    public Transform anchor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = anchor.position;
    }
}
