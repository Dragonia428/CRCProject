using UnityEngine;
using System.Collections;

public class Enemey : MonoBehaviour {
	Vector2 startposition;
	// Use this for initialization
	void Start () {
		startposition =
			gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		if(collision.collider.tag== "Bowser Flower")
			gameObject.transform.position= new Vector2(startposition. x, startposition.y);
	}
}
     