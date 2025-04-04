using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpVelocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y * rotationSpeed);
    }
}
