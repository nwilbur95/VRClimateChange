using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger2 : MonoBehaviour {

	public Text myText;

	IEnumerator OnTriggerEnter()
	{
		myText.text = "A full grown walrus will provide nourishment for up to two weeks.";
		yield return new WaitForSeconds (5);
		myText.text = "";
	}
}
