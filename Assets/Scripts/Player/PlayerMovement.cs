using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 1f;

    void FixedUpdate()
    {
        Vector3 newVelocity = transform.right * Input.GetAxis("Horizontal") * moveSpeed + transform.forward * Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = newVelocity;
    }
}
