using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: This Class still needs written and needs though about how character position will be saved
// Until anything further is done.
/// <summary>
/// This static class will keep track of the characters in the game and tell the game logic
/// whether the given enemy can move in that direction.
/// </summary>
public static class CharacterPositions {

	private static bool[] Enemies;

	static CharacterPositions()
	{
		//Initialize to false when the class is started
		Enemies = new bool[108];
		for (int i = 0; i < Enemies.Length; i++)
		{
			Enemies[i] = false;
		}
	}

	public static bool EnemyAtPosition(float x, float y)
	{
		return true;
	}

	public static bool CharacterAtPosition(float x, float y)
	{
		return false;
	}

	public static void SetPosition(bool taken)
	{

	}

	private static int GetPositionInArray(float x, float y)
	{
		return 1;
	}
	
}
