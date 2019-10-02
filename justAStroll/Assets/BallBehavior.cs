using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    
    float side;
    float forwardBackward;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        side = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        forwardBackward = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = transform.position + new Vector3(side,0, forwardBackward);
    }
}
