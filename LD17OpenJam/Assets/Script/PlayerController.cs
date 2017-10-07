using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class PlayerController : MonoBehaviour {

	public Text scoreLabel;

	private Rigidbody2D rb2d;
	private int score = 0;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.MovePosition(CalculateMouse3DVector());
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Collided");
		if(other.gameObject.CompareTag("trash")){
        	Destroy(other.gameObject);
			score ++;
			scoreLabel.text = "Score: " + score;
			Debug.Log("Destroying");
		}
    }

	private Vector3 CalculateMouse3DVector() {
     Vector3 v3 = Input.mousePosition;
     v3 = Camera.main.ScreenToWorldPoint(v3);
     return v3;
 }
}
