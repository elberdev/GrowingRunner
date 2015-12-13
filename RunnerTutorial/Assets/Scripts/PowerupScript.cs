using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HUDScript hud;

	void OnTriggerEnter2D(Collider2D other) {
	
		// if powerup collides with the player
		if (other.tag == "Player") {
		
			// get hud script and increase the score
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();
			hud.IncreaseScore (10);

			// destroy the powerup
			Destroy (this.gameObject);
		}
	}
}
