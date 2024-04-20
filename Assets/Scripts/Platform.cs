using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
   	public AudioSource myFx;
	public AudioClip jump;
	public float jumpForce;

	void OnCollisionEnter2D(Collision2D collision) {
		
		if(collision.relativeVelocity.y <= 0f) {

			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			
			myFx.PlayOneShot(jump);

			if(rb != null) {
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}
	}
}
