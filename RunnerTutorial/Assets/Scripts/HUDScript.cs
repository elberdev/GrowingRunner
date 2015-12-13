using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;
	
	// Update is called once per frame
	void Update () {
	
		// increase player score based on time
		playerScore += Time.deltaTime;
	}

	// increase player score by a set amount
	public void IncreaseScore(int amount) {
	
		playerScore += amount;
	}

	// when the GUI gets disabled, store the score in the player preferences
	// although this allows cheating if you can access the file on the computer
	void OnDisable() {

		PlayerPrefs.SetInt ("Score", (int) (playerScore * 100));
	}

	void OnGUI() {
	
		// get the score on the screen.
		// make rect at 10, 10
		// make score an int and multiply by 100
		GUI.Label (new Rect (10, 10, 100, 30), "Score: " + (int)(playerScore * 100));
	}
}
