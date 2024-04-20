using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a : MonoBehaviour
{
	public GameObject b;
	public GameObject c;

	public void click() {
		b.SetActive(true);
		c.SetActive(false);
	}
	
	public void change() {
		SceneManager.LoadScene(1);
		MusicController.instance.GetComponent<AudioSource>().Play();
	}
}
