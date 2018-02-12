using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour {

	public Text myText;

	private AudioSource sound;

	// Use this for initialization
	void Start () 
	{
		sound = GetComponent<AudioSource> ();
	}

	// Update is called once per frame

	public void PlaySound()
	{
		sound.Play();
	}

	public void CubClick()
	{
		myText.text = "Your cubs are hungry.";
	}

	public void SealClick()
	{
		myText.text = "That's a walrus, but you can't do anything to it yet...";
	}

}