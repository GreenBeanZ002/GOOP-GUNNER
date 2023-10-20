using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bullet_speed = 3f;
    public Rigidbody2D rb;
    public Vector2 movement;
    
    void Update()
    {
        rb.MovePosition(rb.position + movement * bullet_speed * Time.fixedDeltaTime);
    }

}
