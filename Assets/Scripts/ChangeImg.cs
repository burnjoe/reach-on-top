using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImg : MonoBehaviour
{
	public Sprite newImg;
	public Button button;
	
	public void ChangeImage() {
		button.image.sprite = newImg;
	}
}
