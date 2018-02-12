using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {

	public Text myText;

	public GameObject walrus1;
	public GameObject walrus2;
	public GameObject walrus3;
	public GameObject walrus4;


	private AudioSource sound;
	private int sceneIndex = 1;

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
		myText.text = "You attacked and killed the walrus. The others have fled.";

		Destroy (walrus1);
		Destroy (walrus2);
		Destroy (walrus3);
		Destroy (walrus4);

		StartCoroutine (LoadScene (sceneIndex));
	}

	public IEnumerator LoadScene(int sceneIndex)
	{
		yield return new WaitForSeconds (5);
		myText.text = "Now loading next scene...";

		SceneManager.LoadScene (sceneIndex);
	}
}