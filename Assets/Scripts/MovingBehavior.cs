using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBehavior : MonoBehaviour
{
    // attributes specific for moving platform type of platform
    public float MinPos;
    public float MaxPos;
    public float moveSpeed;
    public bool isVertical;
    [HideInInspector] public float targetPos;


    void Start()
    {
        float[] targetPosArr = {MinPos, MaxPos};
        targetPos = targetPosArr[Random.Range(0, 2)];
    }

    void Update()
    {
        performBehavior();
    }

    public void performBehavior() 
    {
        if (isVertical) {
            // moves the platform back and forth - vertically
            if (transform.position.y == MaxPos) {
                targetPos = MinPos;
            } else if (transform.position.y == MinPos) {
                targetPos = MaxPos;
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetPos, 10f), moveSpeed * Time.deltaTime);
        } else {
            // moves the platform back and forth - horizontally
            if (transform.position.x == MaxPos) {
                targetPos = MinPos;
            } else if (transform.position.x == MinPos) {
                targetPos = MaxPos;
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetPos, transform.position.y, 10f), moveSpeed * Time.deltaTime);
        }
    }
}
