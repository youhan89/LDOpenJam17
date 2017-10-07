using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour {

	private float originY = 5f;
	public Rigidbody2D rb2d;
	public GameObject playerRef;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		ResetTrash();
	}

	void ResetTrash() {
		rb2d.velocity = new Vector3(0f,0f,0f);
		this.transform.position = new Vector3(Random.Range(-4.0f, 4.0f), originY, 0);
	}
	
	// Update is called once per frame
	void Update () {
		float pX = playerRef.transform.position.x;
		float pWidth = playerRef.GetComponent<Renderer>().bounds.size.x;

		if((this.transform.position.x >=  pX - (pWidth/2) ) && ( this.transform.position.x < pX + (pWidth / 2))){
			if(this.transform.position.y < -4.5f) {
				//Destroy(this.gameObject);
			}
		}
		
	}
}
