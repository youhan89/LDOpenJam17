﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void LoadGame() {
		SceneManager.LoadScene("Main");
	}

	public void LoadAbout() {
		SceneManager.LoadScene("About");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
