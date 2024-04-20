using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	//Attributes
	public static bool IsGameOver;
	public GameObject gameoverScreen;
	public GameObject pauseScreen;
	public GameObject pauseButton;
	public GameObject player;
	public GameObject countdown;
	public GameObject platformGenerator;
	public GameObject platform;
	public Text score;
	public Text scoreGameOver;
	public Image start;
	public Sprite ready;
	public Sprite set;
	public Sprite jump;
	public GameObject fx;
	public GameObject camera;
	
	
    	// Start is called before the first frame update
    	void Start() {
			StartCoroutine(CountDown());
			IsGameOver = false;
			gameoverScreen.SetActive(false);
			Time.timeScale = 1f;
    	}

    	// Update is called once per frame
    	void Update() {
		if(IsGameOver) {
			StopCoroutine(CountDown());
			fx.SetActive(false);
			gameoverScreen.SetActive(true);
			scoreGameOver.text = score.text;
			score.gameObject.SetActive(false);
			
		}
    	}

	//Retry
	public void Retry() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Pause() {
		StopCoroutine(CountDown());
		pauseScreen.SetActive(true);
		pauseButton.SetActive(false);
		Time.timeScale = 0f;
	}

	public void Resume() {
		pauseScreen.SetActive(false);
		pauseButton.SetActive(true);
		Time.timeScale =1f;
	}

	IEnumerator CountDown() {
		
		yield return new WaitForSeconds(1f);

		start.sprite = ready;
		yield return new WaitForSeconds(1f);
		
		start.sprite = set;
		yield return new WaitForSeconds(1f);
		
		start.sprite = jump;
		yield return new WaitForSeconds(1f);

		//set true and false
		fx.SetActive(true);
		countdown.SetActive(false);
		player.SetActive(true);
		platformGenerator.SetActive(true);
		platform.SetActive(true);
		score.gameObject.SetActive(true);
		pauseButton.SetActive(true);
		camera.GetComponent<CameraScript>().enabled = true;
		
	}
}
