using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public BulletMovement Bulletsettings;
    public Transform bulletoffset;
    public float Fire_Delay = 1f;
    public float Next_Fire = 0f;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);


     
        if (Input.GetKeyDown("down") && Time.time > Next_Fire)
        {
            BulletMovement goop = Instantiate(Bulletsettings, bulletoffset.position, Quaternion.Euler(new Vector3(0, 0, -90)));
            goop.movement.x = 0;
            goop.movement.y = -1;
            Next_Fire = Time.time + Fire_Delay;
        }
        else if (Input.GetKeyDown("up") && Time.time > Next_Fire)
        {
            BulletMovement goop = Instantiate(Bulletsettings, bulletoffset.position, Quaternion.Euler(new Vector3(0, 0, 90)));
            goop.movement.x = 0;
            goop.movement.y = 1;
            Next_Fire = Time.time + Fire_Delay;
        }
        else if (Input.GetKeyDown("left") && Time.time > Next_Fire)
        {
            BulletMovement goop = Instantiate(Bulletsettings, bulletoffset.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            goop.movement.x = -1;
            goop.movement.y = 0;
            Next_Fire = Time.time + Fire_Delay;
        }
        else if (Input.GetKeyDown("right") && Time.time > Next_Fire)
        {
            BulletMovement goop = Instantiate(Bulletsettings, bulletoffset.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            goop.movement.x = 1;
            goop.movement.y = 0;
            Next_Fire = Time.time + Fire_Delay;
        }
            
 
           
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);



    }
    
    
        
    

}
