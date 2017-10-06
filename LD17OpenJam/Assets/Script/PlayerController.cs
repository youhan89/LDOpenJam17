using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y);
     	transform.position = (pos);
	}
}
