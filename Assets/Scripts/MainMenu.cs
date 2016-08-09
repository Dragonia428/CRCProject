using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void level1()
	{//load level 1
		Application.LoadLevel(1);
	}
	public void level2()
	{//load level 2
		Application.LoadLevel(2);
	}
	public void quit()
	{
		Application.Quit ();
	}
}