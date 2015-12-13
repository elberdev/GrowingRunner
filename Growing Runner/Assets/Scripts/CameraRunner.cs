using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// this will update the camera position relative to the player position,
		// keeping the y coordinate always at zero so the camera doesn't jump
		// with us.
		transform.position = new Vector3(player.position.x + 6, 0, -10);
	}
}
