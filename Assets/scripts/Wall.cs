using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float jumpforce = 10f;
    private Player player;
    Rigidbody2D rb;
    //public Rigidbody2D otherGameObject;

    void OnCollisionEnter2D(Collision2D other)
    {
        rb = other.collider.GetComponent<Rigidbody2D>();
        player = rb.GetComponent<Player>();

        if (rb != null  && player.isColumnJump)
        {
            Vector3 velocity = rb.velocity;
            ///velocity.y = jumpforce;
            //rb.velocity = velocity;  
            rb.AddForce(rb.transform.up * jumpforce, ForceMode2D.Force);
        }
    }

    private void Awake()
    {
        
    }
    
        void Update()
    {

    }
}

