using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed;
    void Start()
    {
        
    }

    private void LateUpdate() //called frame after update
    {
        Vector3 desiredPos = target.position + offset;
        transform.LookAt(target);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, speed*Time.deltaTime);
        transform.position = smoothedPos;
    }
    
}
