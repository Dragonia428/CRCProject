using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Vector2 startposition;
	// Use this for initialization
	void Start () {
		startposition = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D collision){
		if (collision.collider.tag == "Enemy") {
			gameObject.transform.position = new Vector2(startposition.x, startposition.y);
		}

	}
}
