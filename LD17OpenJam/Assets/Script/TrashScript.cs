using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour {

	private float originY = 6f;
	public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		ResetTrash();
	}

	void ResetTrash() {
		rb2d.velocity = new Vector3(0f,0f,0f);
		rb2d.AddTorque(Random.Range(-20.0f, 20.0f));
		this.transform.position = new Vector3(Random.Range(-4.0f, 4.0f), originY, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
