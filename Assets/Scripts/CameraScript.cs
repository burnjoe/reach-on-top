using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // sprite/background where camera will fit in
    public SpriteRenderer background;
    public float moveSpeed;
    public Transform target;
    public Transform mark;

    // Start is called before the first frame update
    void Start()
    {
        FixedScreen();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3(transform.position.x, transform.position.y + 1 * moveSpeed * Time.deltaTime);   

        if (target.position.y <= mark.position.y) {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1 * moveSpeed * Time.deltaTime);
        }

        if (target.position.y > mark.position.y) {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, target.position.y), moveSpeed * Time.deltaTime);
        }
    }
    	
   //void LateUpdate() {
      //  if (target.position.y > mark.position.y) {
           // transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, target.position.y), moveSpeed * Time.deltaTime);
       //}
 //   }


   void FixedScreen() 
    {
        // fix screen within background's width edge 
        float orthoSize = (background.bounds.size.x * Screen.height / Screen.width * 0.5f) - 0.1f;
        Camera.main.orthographicSize = orthoSize;
    }
}   
