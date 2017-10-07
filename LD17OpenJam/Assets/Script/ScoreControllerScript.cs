using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControllerScript : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {

	}

	public void SaveToPrefs(){
 		PlayerPrefs.SetInt("lastscore", score);
		if(score > PlayerPrefs.GetInt("highscore")){
			PlayerPrefs.SetInt("highscore", score);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
