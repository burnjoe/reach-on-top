using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{    
    // list of available platform behaviors
    public enum BehaviorList {
        Still,
        Breaking,
        Moving,
        Bounce
    }
    // behavior of this platform, similar function as Tag
    public BehaviorList behavior;
    [Range(0,10)] public int chance;

    public float jumpForce;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().hasCollide = true;
            }
        }    
    }

    private void OnCollisionExit2D(Collision2D collision) {
        GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().hasCollide = false;
    }

}
