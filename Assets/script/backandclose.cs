using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backandclose : MonoBehaviour {
	
	public void backbttn()
{
		SceneManager.LoadScene("APP");
}

	public void exit()
 {
		Application.Quit ();
		Debug.Log("Exit button pressed");
}
	
}
