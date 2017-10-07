using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.MovePosition(CalculateMouse3DVector());
	}

	private Vector3 CalculateMouse3DVector() {
     Vector3 v3 = Input.mousePosition;
     v3 = Camera.main.ScreenToWorldPoint(v3);
     Debug.Log(v3); //Current Position of mouse in world space
     return v3;
 }
}
