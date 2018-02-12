using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger1 : MonoBehaviour {

	public Text myText;
	public AudioSource sealSound;

	IEnumerator OnTriggerEnter()
	{
		myText.text = "You hear a herd of walruses in the distance.";
		sealSound.Play ();
		yield return new WaitForSeconds (5);
		myText.text = "";
	}
}
