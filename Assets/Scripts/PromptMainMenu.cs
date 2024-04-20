using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PromptMainMenu : MonoBehaviour
{

void Start() 
{

}

void Update()
{
    StartCoroutine(DelayTime());
}

IEnumerator DelayTime() 
{
 yield return new WaitForSeconds(80);

 SceneManager.LoadScene(1);
}

}
