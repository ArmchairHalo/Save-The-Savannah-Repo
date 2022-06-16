using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    public float jumpSpeed = 20;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    private Rigidbody2D physicsBody = null;
    private bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float axisVal = Input.GetAxis("Horizontal");

        float axisVal2 = Input.GetAxis("Vertical");
        //physicsBody.velocity = new Vector2(axisVal * speed, axisVal2 * speed);

        // (x axis value, y axis value)
    }

    public void MoveRight()
    {
        physicsBody.velocity = new Vector2(speed, physicsBody.velocity.y);
    }

    public void MoveLeft()
    {
        physicsBody.velocity = new Vector2(-speed, physicsBody.velocity.y);
    }

    public void Jump()
    {
        Debug.Log("JumpPressed");
        if (canJump)
        {
            physicsBody.velocity = new Vector2(physicsBody.velocity.x, jumpSpeed);
            Debug.Log("AttemptJump");
            canJump = false;
        }

    }
    private void FixedUpdate()
    {
        canJump = Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        
    }
}
