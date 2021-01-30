using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 forceVector = new Vector3(0, 0, Input.GetAxis("Horizontal"));
        rb.AddForce(forceVector * speed);
        
    }
}
