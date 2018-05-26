using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject ToSpawn;
	public float spawnRate;
	public GameObject Road;

	private float timeSinceLastSpawn = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeSinceLastSpawn > 1 / spawnRate)
		{
			var character = Instantiate(ToSpawn);
			character.GetComponent<Drone>().Road = Road;
			character.transform.position = transform.position;
			timeSinceLastSpawn = 0;
		}

		timeSinceLastSpawn += Time.deltaTime;
	}
}
