using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour {


	private float originY;
	public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		this.originY = this.transform.position.y;
	}

	void ResetTrash() {
		rb2d.velocity = new Vector3(0f,0f,0f);
		this.transform.position = new Vector3(Random.Range(-4.0f, 4.0f), originY, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -10) {
			ResetTrash();
		}
	}
}
