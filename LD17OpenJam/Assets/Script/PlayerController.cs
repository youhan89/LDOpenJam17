using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour {

	public Text scoreLabel;

	private Rigidbody2D rb2d;

	public ScoreControllerScript scoreController;

	public AudioClip pickup;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource>();
		scoreController.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.MovePosition(CalculateMouse3DVector());
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("trash")){
        	Destroy(other.gameObject);
			audioSource.PlayOneShot(pickup, 0.1f);
			scoreController.score ++;
			scoreLabel.text = "Score: " + scoreController.score;
		}
    }

	private Vector3 CalculateMouse3DVector() {
     Vector3 v3 = Input.mousePosition;
     v3 = Camera.main.ScreenToWorldPoint(v3);
     return v3;
 }
}
