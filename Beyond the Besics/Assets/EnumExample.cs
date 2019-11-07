using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{

	private int gameState;
	void Start ()
	{
		gameState = 0;
	}
	
	void Update () {
		switch (gameState)
		{
			case 2:
				Debug.Log("The game has ended");
				break;
			case 0:
				Debug.Log("The game is running");
				break;
			case 1:
				Debug.Log("The game is paused");
				break;
		}
	}
}

public enum GameState { Running , Paused , Ended }
