using Unity.VisualScripting;
using UnityEngine;

public class rotateRoot : MonoBehaviour
{
    public GameObject frontSpineBone;
    public GameObject backSpineBone;
    Quaternion frontRotation;
    Quaternion rearRotation;
    Quaternion rootRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        frontRotation = frontSpineBone.transform.rotation;
        rearRotation = backSpineBone.transform.rotation;
        rootRotation = Quaternion.Slerp(frontRotation, rearRotation, 0.5f);

        if(rootRotation.w <=0 && rootRotation.z >=0)
        {
            (rootRotation.z, rootRotation.w) = (rootRotation.w, rootRotation.z);
        }
        //Debug.Log(rootRotation + "Before CHange");
        rootRotation.z = Mathf.Abs(rootRotation.z);
        rootRotation.w = Mathf.Abs(rootRotation.w);
        //Debug.Log(rootRotation + "After Change");
        if(rootRotation.z !>= 0 )
        {
            //Debug.Log("true");
            //rootRotationVector.z *= -1;
            //rootRotation = Quaternion.LookRotation(rootRotationVector, Vector3.up);
        }
        else
        {
            //Debug.Log("false");
        }

        this.transform.rotation = rootRotation;
        //Debug.Log(frontRotation.z + ", " + frontRotation.w + "   " + rearRotation.z + ", " + rearRotation);
    }
}
