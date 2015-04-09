using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
	
	int max;
	int min;
	int guess;

	public int maxGuessAllowed = 5;
	public Text text;

	// Use this for initialization
	void Start ()
	{
		StartGame ();
	}

	void StartGame ()
	{
		max = 1001;
		min = 1;
		NextGuess ();
	}

	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}

	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}

	// Update is called once per frame
	void Update ()
	{
		//if (guess <= min || max <= guess) {
		//	Application.LoadLevel ("Cheat");}


	}
	
	void NextGuess ()
	{
		guess = Random.Range (min, max + 1);

		text.text = guess.ToString ();


		maxGuessAllowed--;
		if (maxGuessAllowed <= 0) {
			Application.LoadLevel ("Win");
		}
	}

}
