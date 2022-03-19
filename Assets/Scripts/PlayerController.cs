using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    private Rigidbody playerRb;
    private float horizontal;
    private float vertical;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
        OutOfBounds();
    }

    void Movement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * horizontal * speed);
        playerRb.AddForce(Vector3.forward * vertical * speed);
    }

    void OutOfBounds()
    {
        if (transform.position.y < -4)
        {
            Debug.Log("Gameover");
            Destroy(gameObject);
        }
    }
}
