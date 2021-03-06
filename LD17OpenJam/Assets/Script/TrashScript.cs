﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour {

	private float originY = 6f;
	public Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		ResetTrash();
	}

	void ResetTrash() {
		rb2d.velocity = new Vector3(0f,0f,0f);
		rb2d.AddTorque(Random.Range(-20.0f, 20.0f));
		this.transform.position = new Vector3(Random.Range(-6.0f, 6.0f), originY, 0);
	}
	
	void Update () {
		if(transform.position.y < -7){
			this.gameObject.SetActive(false);
		}
	}
}
