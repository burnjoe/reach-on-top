using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CharacterMovement : MonoBehaviour
{
	//Attributes
   	public float movementSpeed = 10f;
	Rigidbody2D rb;
	float movement = 0f;
	public Animator animator;
	public Text scoreText;
	public Transform player;
	[HideInInspector] public bool hasCollide = false;
	//public Transform anchor;
	
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update() {

		movement = Input.GetAxis("Horizontal");
		animator.SetFloat("IsJump", rb.velocity.y);
		
		if(rb.velocity.y > 0f) {
			scoreText.text = "SCORE: " + Math.Floor(player.position.y * 10) + " m";
		}
		
		//moving right
		if(movement > 0f) {

			rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);

			//icacopy mo yung scale ng character, yung X (0.04287102) tsaka Y (0.02015156)
			transform.localScale = new Vector2(Math.Abs(transform.localScale.x), Math.Abs(transform.localScale.y));

		}
		
		//moving left
		else if(movement < 0f) {
			rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);
			
			//Gawing negative yung value ng X para maflip yung character
			transform.localScale = new Vector2(-Math.Abs(transform.localScale.x), Math.Abs(transform.localScale.y));
		}

	}
	
}
