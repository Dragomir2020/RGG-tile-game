using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll)
	{
		//In the future need to check for differnt types of game objects that could collide with this
		if (coll.gameObject.GetComponent<RoundEnemy>().ShouldDelete())
		{
			Destroy(coll.gameObject);
		}
	}
}
