using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChanger : MonoBehaviour
{
	public GameObject rightButton1;
	public GameObject leftButton1;
	public GameObject rightButton2;
	public GameObject leftButton2;
	public GameObject castleMap;
	public GameObject hellTower;
	public GameObject frostTower;

	public void RightButton1Effect() {
		castleMap.SetActive(false);
		rightButton1.SetActive(false);
		rightButton2.SetActive(true);
		leftButton1.SetActive(true);
		hellTower.SetActive(true);
	}
	
	public void LeftButton1Effect() {
		castleMap.SetActive(true);
		rightButton1.SetActive(true);
		leftButton1.SetActive(false);
		rightButton2.SetActive(false);
		hellTower.SetActive(false);
	}
	
	public void RightButton2Effect() {
		hellTower.SetActive(false);
		rightButton2.SetActive(false);
		frostTower.SetActive(true);
		leftButton2.SetActive(true);
	}

	public void LeftButton2Effect() {
		hellTower.SetActive(true);
		rightButton2.SetActive(true);
		leftButton1.SetActive(true);
		frostTower.SetActive(false);
		leftButton2.SetActive(false);
	}
}
