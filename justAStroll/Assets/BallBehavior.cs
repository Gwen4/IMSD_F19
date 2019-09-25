using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    // Code From Unity Youtube Channel: https://www.youtube.com/watch?v=7C7WWxUxPZE
    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 position = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddTorque(position * speed);
    }
}
