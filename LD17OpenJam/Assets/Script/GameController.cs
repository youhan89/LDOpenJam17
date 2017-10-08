using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject trash, trash_2, battery, apple, cup;

	public bool shouldSpawn = true;
	public float spawnRate = 5f;
	private float timeLeft;

	private List<GameObject> trashtypes = new List<GameObject>();

	// Use this for initialization
	void Start () {
		timeLeft = spawnRate;
		trashtypes.Add(trash);
		trashtypes.Add(trash_2);
		trashtypes.Add(battery);
		trashtypes.Add(apple);
		trashtypes.Add(cup);
	}
	
	GameObject GetRandomTrashType() {
		int randomPostion = Random.Range(0, trashtypes.Count);
		return trashtypes[randomPostion];
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
			 if(shouldSpawn){
			 	timeLeft = spawnRate;
				 Instantiate(GetRandomTrashType());
			 }
         }
	}
}
