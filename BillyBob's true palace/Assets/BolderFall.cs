using UnityEngine;
using System.Collections;

public class BolderFall : MonoBehaviour {
	public float time=0;
	public bool myswitch; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (myswitch) {
			time += Time.deltaTime;
			Debug.Log (time.ToString ());
			if (time > 5) {
				gameObject.GetComponent<Rigidbody2D> ().gravityScale = 5;
			}
		}

	}
	void OnCollisionEnter2D (Collision2D collision){
		if(collision.collider.tag == "Player")
		{
			myswitch = true;

		}
	}


}
	