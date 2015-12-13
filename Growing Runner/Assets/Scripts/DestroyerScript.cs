using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
	
		if (other.tag == "Player") {

			// Load the next scene when player dies
			//Debug.Break ();
			Application.LoadLevel(1);

			return;
		}

		// if the object has a parent, destroy the parent
		if (other.gameObject.transform.parent) {
		
			Destroy (other.gameObject.transform.parent.gameObject);
		
		// otherwise destroy the object itself
		} else {
		
			Destroy (other.gameObject);
		}
	}
}
