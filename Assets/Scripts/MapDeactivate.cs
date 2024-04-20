using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapDeactivate : MonoBehaviour
{
	public GameObject SelectMap;

	public void Deactivate() {
		SelectMap.SetActive(false);
	}
}
