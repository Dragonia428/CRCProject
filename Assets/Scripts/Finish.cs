using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	private static int level;
	void Start()
	{
		level = Application.loadedLevel;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Finish"){
			Application.LoadLevel ((level + 1) % 3);
		} 
	}

}
