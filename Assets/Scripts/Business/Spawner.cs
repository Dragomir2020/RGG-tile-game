using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject RoundEnemy;
	public GameObject SquareEnemy;
	public GameObject Thistle;

	// Use this for initialization
	void Start () {
		Instantiate(RoundEnemy, new Vector3(0f, RoundEnemy.transform.position.y + 2f, RoundEnemy.transform.position.z), RoundEnemy.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
