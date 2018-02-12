using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger4 : MonoBehaviour {

	public Text myText;
	public bool inRange = false;

	IEnumerator OnTriggerEnter()
	{
		myText.text = "You are now in range to attack. Click a walrus to hunt it.";
		yield return new WaitForSeconds (5);
		myText.text = "";
		inRange = true;
	}

	void OnTriggerExit()
	{
		inRange = false;
	}
}