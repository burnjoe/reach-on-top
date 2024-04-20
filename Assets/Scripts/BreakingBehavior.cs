using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBehavior : MonoBehaviour
{
    public float delay;
    [HideInInspector] public GameObject player;
    // private float maxY = 0;

    void Start()
    {
        
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // if (player.position.y > maxY) {
        //     maxY = player.position.y;
        // }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // player.transform.position.y > transform.position.y &&
        // destroys the breaking platform with delay, once player collides with it
        if (collision.gameObject.tag == "Player" &&  player.GetComponent<CharacterMovement>().hasCollide) {
            Destroy(gameObject, delay);
        }
    }

}
