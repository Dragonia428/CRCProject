using UnityEngine;
using System.Collections;

public class coincolletion : MonoBehaviour {
	public static int numberofcoins = 0;
	public GUIStyle mystyle; 
	public float height, width, size1, size2;
	// Use this for initialization
	void Awake()
	{
		
	}
	void Start () {
		height = Screen.height / 2 - 100; 
		width = Screen.width / 2;
		size1 = 200;
		size2 = 200; 
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("numberofcoins", numberofcoins); 

	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Coin") {

			numberofcoins++; //numberofcoins
			Destroy (other.gameObject);
		}
	}
	void OnGUI() 
	{
		GUI.TextField(new Rect(new Vector2(width, height), 
			new Vector2(size1, size2)), 
			"Coins collected: " + numberofcoins, mystyle);
	}

 }




