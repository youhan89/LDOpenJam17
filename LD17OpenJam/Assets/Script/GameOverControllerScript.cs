using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverControllerScript : MonoBehaviour {

	public Text lastScoreText, highScoreText;

	// Use this for initialization
	void Start () {
		drawLastScore();
		drawHighscore();
	}

	private void drawLastScore(){
		int lastScore = PlayerPrefs.GetInt("lastscore");
		lastScoreText.text = "Score : " + lastScore;
	}

	private void drawHighscore(){
		int highScore = PlayerPrefs.GetInt("highscore");
		highScoreText.text = "Highscore : " + highScore;
	}
	
	public void LoadGame() {
		SceneManager.LoadScene("Menu");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
