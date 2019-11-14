using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RCnew: MonoBehaviour {
	
	public void rc()
{
		SceneManager.LoadScene("Rotatingcube");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
	
}
