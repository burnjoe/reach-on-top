using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // attributes
    [HideInInspector] public bool isVisible = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible() 
    {
        if (isVisible) {
            // once the platform (gameobject) gets out of the screen, destroy this game object
            Destroy(gameObject);
        }
    }

    private void OnBecameVisible() 
    {
        isVisible = true;    
    }
}
