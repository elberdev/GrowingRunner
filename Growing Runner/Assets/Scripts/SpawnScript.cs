using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	// what to spawn
	public GameObject[] obj;

	// how fast to spawnt the objects?
	public float spawnMin;
	public float spawnMax;

	// Use this for initialization
	void Start () {
	
		Spawn ();
	}

	void Spawn() {
	
		// instantiate a random object from the array at our script object's position 
		// with default orientation (rotation)
		Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);

		// this calls the Spawn() function after a random time between min and max
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
