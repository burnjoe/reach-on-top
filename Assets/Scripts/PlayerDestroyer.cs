using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    	// attributes
	[HideInInspector] public bool isPlayerVisible = false;

	private void OnBecameInvisible() {
       		if (isPlayerVisible) {
			GameManager.IsGameOver = true;
			Time.timeScale = 0;
        		}
    	}

	private void OnBecameVisible() {
        		isPlayerVisible = true;    
    	}


}
