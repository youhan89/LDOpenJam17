using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject trash;

	public bool shouldSpawn = true;
	public float spawnRate = 5f;
	private float timeLeft;

	// Use this for initialization
	void Start () {
		timeLeft = spawnRate;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
			 if(shouldSpawn){
			 	timeLeft = spawnRate;
				 Instantiate(trash);
				
			 }
         }
	}
}
