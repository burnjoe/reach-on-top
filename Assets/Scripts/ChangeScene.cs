using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void MoveToScene1(int sceneID) {
		if(sceneID == 1) {
			SceneManager.LoadScene(1);
		}

		if(sceneID == 2) {
			SceneManager.LoadScene(2);
		}

		if(sceneID == 3) {
			SceneManager.LoadScene(3);
		}

		if(sceneID == 4) {
			SceneManager.LoadScene(4);
		}

		if(sceneID == 5) {
			SceneManager.LoadScene(5);
		}

		if(sceneID == 6) {
			SceneManager.LoadScene(6);
			MusicController.instance.GetComponent<AudioSource>().Stop();
		}

		if(sceneID == 7) {
			SceneManager.LoadScene(7);
			MusicController.instance.GetComponent<AudioSource>().Stop();
		}

		if(sceneID == 8) {
			SceneManager.LoadScene(1);
			MusicController.instance.GetComponent<AudioSource>().Play();
		}
			
	}

	public void MoveToScene(int sceneID) {
		
		if(sceneID == 1) {
			StartCoroutine(MainMenu());
		}
		
		if(sceneID == 2) {
			StartCoroutine(CastleMap());
		}

		if(sceneID == 3) {
			StartCoroutine(HellMap());
		}

		if(sceneID == 4) {
			StartCoroutine(FrostMap());
		}

		if(sceneID == 5) {
			StartCoroutine(Option());
		}

		if(sceneID == 6) {
			StartCoroutine(CastleGame());
		}

		if(sceneID == 7) {
			StartCoroutine(HellGame());
		}

		if(sceneID == 8) {
			SceneManager.LoadScene(1);
		}
	}
	
	
	 IEnumerator MainMenu() {
       		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(1);
    	}

	 IEnumerator CastleMap() {
       		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(2);
		MusicController.instance.GetComponent<AudioSource>().Play();
    	}

	 IEnumerator HellMap() {
       		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(3);
		MusicController.instance.GetComponent<AudioSource>().Play();
    	}

	 IEnumerator FrostMap() {
       		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(4);
    	}

	 IEnumerator Option() {
       		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(5);
    	}

	 IEnumerator CastleGame() {
       		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(6);
		MusicController.instance.GetComponent<AudioSource>().Stop();
    	}

	 IEnumerator HellGame() {
       		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(7);
		MusicController.instance.GetComponent<AudioSource>().Stop();
    	}
}
