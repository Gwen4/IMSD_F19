using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public float decNumber = 0.01f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObject(this.transform, Vector3.up * Time.deltaTime);
    }

    void moveObject(Transform transformToBeMoved, Vector3 amount)
    {
        transformToBeMoved.position += amount;
    }
}