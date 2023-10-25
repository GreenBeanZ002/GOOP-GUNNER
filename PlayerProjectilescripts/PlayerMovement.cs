using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;
    public Vector2 movementtotal;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);

    }
    private void FixedUpdate()
    {
        movementtotal = movement * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movementtotal);



    }
    
    
        
    

}
