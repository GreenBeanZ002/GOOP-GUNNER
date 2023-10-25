using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bullet_speed = 3f;
    public Rigidbody2D rb;
    public Vector2 movement;
    

    private void Start()
    {

        GameObject slime = GameObject.FindGameObjectWithTag("MySlime");
        Physics2D.IgnoreCollision(slime.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        
    }
    void Update()
    {
        Physics2D.IgnoreLayerCollision(3, 3);
        rb.MovePosition(rb.position + movement * bullet_speed * Time.fixedDeltaTime);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
