using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
	public AudioSource myFx;
	public AudioClip gameOver;
	
	public void Start() {
		myFx.PlayOneShot(gameOver);
	}
}
