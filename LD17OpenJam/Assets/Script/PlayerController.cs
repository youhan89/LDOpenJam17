using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;

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
        Destroy(other.gameObject);
    }

	private Vector3 CalculateMouse3DVector() {
     Vector3 v3 = Input.mousePosition;
     v3 = Camera.main.ScreenToWorldPoint(v3);
     return v3;
 }
}
