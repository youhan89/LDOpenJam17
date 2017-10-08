using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MenuControllerScript : MonoBehaviour {

	public AudioClip blip;
    AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	public void playButtonSound(){
		audioSource.PlayOneShot(blip, 0.5f);
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
