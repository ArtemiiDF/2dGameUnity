using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 9.8f;
    public float jumpForce = 15.0f;
    

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jumping();

    }
    void Movement()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        float movementByX = moveHorizontal * speed;

        rb2d.velocity = new Vector2(movementByX, rb2d.velocity.y);
    }

    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }

    }
}
