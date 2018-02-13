using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour {

	public AudioSource walkSound;

	private bool isWalking;

	// Use this for initialization
	void Start () 
	{
		isWalking =  gameObject.GetComponent<Autowalk> ().isWalking;
	}
	
	// Update is called once per frame
	void Update () 
	{
		while (isWalking) 
		{
			walkSound.volume = Random.Range (0.8f, 1);
			walkSound.pitch = Random.Range (0.8f, 1.1f);
			walkSound.Play ();
		}
	}
}
