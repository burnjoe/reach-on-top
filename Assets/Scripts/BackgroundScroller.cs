using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnBecameInvisible() { 
        transform.position = new Vector3(transform.position.x, transform.position.y+117.12f, transform.position.z);
    }

}
