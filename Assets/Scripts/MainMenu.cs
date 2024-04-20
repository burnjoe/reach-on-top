using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Next() 
    {
        StartCoroutine(D_Next());
    }

    public void Back() 
    {
        StartCoroutine(D_Back());
    }

    public void BacktoMainMenu() 
    {
        StartCoroutine(D_BacktoMainMenu());
    }

    public void Options() 
    {
        StartCoroutine(D_Options());
    }

    public void CastleMap() 
    {
        StartCoroutine(D_CastleMap());
    }

    public void HellMap() 
    {
        StartCoroutine(D_HellMap());
    }

    public void CastleMapToMain() {
	SceneManager.LoadScene(0);
	MusicController.instance.GetComponent<AudioSource>().Play();
    }

    IEnumerator D_Next() 
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator D_Back() 
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

   IEnumerator D_BacktoMainMenu() 
   {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
   }

    IEnumerator D_Options() 
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(4);
    }

    IEnumerator D_CastleMap() 
   {
       yield return new WaitForSeconds(3);

       SceneManager.LoadScene(5);
	
       MusicController.instance.GetComponent<AudioSource>().Pause();
   }

     IEnumerator D_HellMap() 
     {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(6);
        MusicController.instance.GetComponent<AudioSource>().Pause();
     }
}
