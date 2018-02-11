using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

	public Text myText;

	// Use this for initialization
	IEnumerator Start () 
	{
		//Text sets your text to say this message
		myText.text = "You have just awoken from hibernation.";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}

		yield return new WaitForSeconds (2);
		myText.text = "You must find a way to feed your cubs.";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}
	}
	

}
