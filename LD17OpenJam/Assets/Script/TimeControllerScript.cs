using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class TimeControllerScript : MonoBehaviour {

	public float GameDuration = 90;
	public Text timeLabel;
	public GameController gc;

	public ScoreControllerScript scoreController;

	private float timeLeft = 0;
	

	void Start () {
		timeLeft = GameDuration;
	}

	private void GameOver(){
		scoreController.SaveToPrefs();
		LoadGameOverScene();
	}

	public void LoadGameOverScene() {
		SceneManager.LoadScene("GameOver");
	}

	private void drawTimeLabel() {

		string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
 		string seconds = Mathf.Floor(timeLeft % 60).ToString("00");

		string time = minutes + ":" + seconds;

		timeLabel.text = "Time left : " + time;
	}

	void Update () {
		timeLeft -= Time.deltaTime;

		Debug.Log("TIME LEFT : " + timeLeft);

		if(timeLeft>59.5f && timeLeft<60.5f){
			gc.spawnRate = 0.8f;
			Debug.Log("INCREASING RATE!!!!");
		} else if(timeLeft>29.5f && timeLeft<30.5f){
			gc.spawnRate = 0.5f;
			Debug.Log("INCREASING RATE MOAR!!!!!");
		}

		if(timeLeft <= 0) {
			gc.spawnRate = 0;
			GameOver();
		} else {
			drawTimeLabel();
		}
	}
}
