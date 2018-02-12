using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentText : MonoBehaviour {

	public Text myText;

	// Use this for initialization
	IEnumerator Start () 
	{
		//Text sets your text to say this message
		myText.text = "You have just awoken from hibernation";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}

		yield return new WaitForSeconds (2);
		myText.text = " ";

		yield return new WaitForSeconds (3);

		myText.text = "One of your cubs did not survive the winter";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}

		yield return new WaitForSeconds (4);

		myText.text = "You do not see or hear any walruses.";
		yield return new WaitForSeconds (4);

		myText.text = "There is not much ice for them to rest on.";
		yield return new WaitForSeconds (4);

		myText.text = "It may take weeks before you eat.";
		yield return new WaitForSeconds (4);

		myText.text = "Human activity has raised global temperatures, casuing sea ice to melt.";
		yield return new WaitForSeconds (4);

		myText.text = "With less sea ice, polar bears struggle to find food.";
		yield return new WaitForSeconds (4);

		myText.text = "At this rate, two-thirds of the worlds polar bears will be gone by 2050.";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}

		myText.text = "They will be exctint in less than 100 years.";

		for (int i = 0; i < 3; i++) 
		{
			yield return new WaitForSeconds (1);
			myText.text += ".";
		}
	}
}
