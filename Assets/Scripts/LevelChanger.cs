using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetButtonDown("Start")) 
        {
             FadetoScene(1);
        }

        if(Input.GetButtonDown("Options")) 
        {
            FadetoScene(4);
        }
    }

    public void FadetoScene(int LevelIndex) 
    {
        levelToLoad = LevelIndex;
        animator.SetTrigger("Fade Out");
    }

    public void OnFadeComplete() 
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
