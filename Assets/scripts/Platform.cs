using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpforce = 10f;

   void OnCollisionEnter2D(Collision2D other) {
       Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
       /*if(rb!=null && rb.velocity.y <=0 )
       {         
           Vector2 velocity = rb.velocity;
           velocity.y = jumpforce;
           rb.velocity = velocity;
       }*/
   }

    private void Update()
    {
       // transform.Translate(Vector3.down * (Time.deltaTime * 10));
    }
    
}
