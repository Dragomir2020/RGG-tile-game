using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class RoundEnemy : MonoBehaviour {

	private Animator RoundEnemyAnimator;
	private float TimeSince;
	private bool shouldDelete = false;
	public float WaitTime = 3; // Should not be less than or equal to one
	private System.Random rnd = new System.Random();
	private bool Top;
	private bool Bottom;
	private bool Left;
	private bool Right;

	void Awake()
	{
		RoundEnemyAnimator = this.GetComponent<Animator>();
		TimeSince = 0;
	}

	// Use this for initialization
	void Start()
	{
		//RoundEnemyAnimator = this.GetComponent<Animator>();
		//TimeSince = 0;
	}

	// Update is called once per frame
	void Update()
	{
		TimeSince += Time.deltaTime;
		if (TimeSince > WaitTime)
		{
			TimeSince = 0;
			CheckEdges();
			int numb = rnd.Next(0, 3);
			if (numb == 0 && !Top) // Move Up
			{
				RoundEnemyAnimator.SetTrigger("moveUp");
			}
			else if (numb == 1 && !Bottom) // Move Down
			{
				RoundEnemyAnimator.SetTrigger("moveDown");
			}
			else if (numb == 2) // Move Left
			{
				RoundEnemyAnimator.SetTrigger("moveLeft");
			}
			else // Move Right
			{
				RoundEnemyAnimator.SetTrigger("moveRight");
			}
		}
	}

	public bool ShouldDelete()
	{
		return shouldDelete;
	}

	public void SetTrigger(string animation)
	{
		RoundEnemyAnimator.SetTrigger(animation);
	}

	/// <summary>
	/// Moves the child transform and rotation left.
	/// </summary>
	public void MoveChildLeft()
	{
		MoveChild(new Vector3(-0.5f, 0f, 0f), new Vector3(0f, 0f, 90f));
		/*if (shouldDelete)
		{
			Destroy(this.gameObject);
		}*/
	}

	/// <summary>
	/// Moves the child transform and rotation right.
	/// </summary>
	public void MoveChildRight()
	{
		MoveChild(new Vector3(0.5f, 0f, 0f), new Vector3(0f, 0f, -90f));
	}

	/// <summary>
	/// Moves the child transform and rotation up.
	/// </summary>
	public void MoveChildUp()
	{
		MoveChild(new Vector3(0f, 0.5f, 0f), new Vector3(0f, 0f, -90f));
	}

	/// <summary>
	/// Moves the child transform and rotation down.
	/// </summary>
	public void MoveChildDown()
	{
		MoveChild(new Vector3(0f, -0.5f, 0f), new Vector3(0f, 0f, 90f));
	}

	private void MoveChild(Vector3 Position, Vector3 Rotation)
	{
		this.transform.position += Position;
		this.transform.GetChild(0).GetChild(0).Rotate(Rotation);
	}

	public void CheckLeft()
	{
		CheckEdges();
		if (Left)
		{
			shouldDelete = true;
			GameObject newCharacter = Instantiate(this.gameObject, new Vector3(2.5f, this.transform.position.y, this.transform.position.z), this.transform.rotation);
			newCharacter.GetComponent<RoundEnemy>().SetTrigger("moveLeft");
		}
	}

	public void CheckRight()
	{
		CheckEdges();
		if (Right)
		{
			shouldDelete = true;
			GameObject newCharacter = Instantiate(this.gameObject, new Vector3(-2.5f, this.transform.position.y, this.transform.position.z), this.transform.rotation);
			newCharacter.GetComponent<RoundEnemy>().SetTrigger("moveRight");
		}
	}

	private void CheckEdges()
	{
		if (this.transform.position.x <= -2f)
		{
			Left = true;
		}
		if (this.transform.position.x >= 2f)
		{
			Right = true;
		}
		if (this.transform.position.y <= -2.5f)
		{
			Bottom = true;
		}
		if (this.transform.position.y >= 3f)
		{
			Top = true;
		}



	}

}
