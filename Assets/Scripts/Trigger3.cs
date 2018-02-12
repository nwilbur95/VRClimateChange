using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger3 : MonoBehaviour {

	public Text myText;

	IEnumerator OnTriggerEnter()
	{
		myText.text = "Approach one of the walruses to attack it.";
		yield return new WaitForSeconds (5);
		myText.text = "";
	}
}