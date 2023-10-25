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
        //GameObject[] projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        //print(projectiles[0]);
        //if (projectiles[0] != null)
        //
        //{
        //    
        //    for (int i = 0; i < projectiles.Length; i++)
        //    {
        //        Physics2D.IgnoreCollision(projectiles[i].GetComponent<Collider2D>(), GetComponent<Collider2D>());
        //    }
        //}
        rb.MovePosition(rb.position + movement * bullet_speed * Time.fixedDeltaTime);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
