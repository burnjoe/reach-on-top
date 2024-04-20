using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
   	public Transform target;
	public float smoothSpeed = .3f;
	public Transform mark;
	 public float moveSpeed;

	void Update() {
		if(target.position.y > transform.position.y) {
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
