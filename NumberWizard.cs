using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int maxValue;
	int minValue;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame(){
		maxValue = 1000;
		minValue = 1;
		guess = 500;
		Debug.Log ("It's-a my number wizard");
		Debug.Log ("Pick a number, don't tell me what it is");
		Debug.Log ("The highest number you can pick is: " + maxValue);
		Debug.Log ("The lowest number you can pick is: " + minValue);
		Debug.Log ("Tell if your number is lower or higher than: " + guess);
		Debug.Log ("Push up = higher, push down = lower, Push Enter = Correct");
		maxValue = maxValue + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			minValue = guess;
			NextGuess();

		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{	
			maxValue = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("I got it!");
			StartGame ();
		}
	}

	void NextGuess(){
		guess = (maxValue + minValue) / 2;
		Debug.Log("Is it higher or lower than... " + guess);
	}
}
