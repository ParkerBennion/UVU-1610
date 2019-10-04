using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour

{
	public string playerName;
	private int myNumber;
	public Color playerColor = Color.magenta;
	public GameObject player;
	// Use this for initialization
	void Start ()
	{
		myNumber = AddNumbers(a: 10 ,b: 5);
		print(WelcomePlayer() );

		ConfigGameObject();
	}

	private GameObject ConfigGameObject() // 1 
	{
		var newPlayer = Instantiate(player);
		newPlayer.layer = 0;
		newPlayer.active = true;
		newPlayer.transform.position = Vector3.zero;
		newPlayer.tag = "player";
		newPlayer.name = playerName;
		newPlayer.GetComponent<Renderer>().material.color = playerColor;
		return newPlayer;
	}
private string WelcomePlayer()
	{
		return playerName + "Welcome to the game!";
	}
	private int AddNumbers(int a, int b)
	{
		print(a+b);
		return a + b;
		//make a player data scriptable object and populate it with variables
	}
}
