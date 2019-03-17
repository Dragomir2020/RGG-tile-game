using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	/// <summary>
	/// Loads the scene.
	/// </summary>
	/// <param name="name">Name.</param>
	public void loadScene(string name)
	{
		SceneManager.LoadScene(name);
	}


}
