using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
		rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y);
     	transform.position = (pos);
	}
}
