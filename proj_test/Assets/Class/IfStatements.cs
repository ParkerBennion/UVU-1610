using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
	public int a = 4;
	public int b = 5;
	public int c = 10;
	public string password = "0U812";
	public bool lightOn = true;
	void Start () {
		if (a+b == c)
		{
			print(true);
		}
		else
		{
			print(false);
		}
		if (password == "OU812") //(password != "OU812") /anything but OU812 is true.
		{
			print(true);
		}

		if (!lightOn) //"!" means if this is not true print true.
		{
			print(true);
		}
	}
	// "||" this means or.
	void Update () {
		
	}
}
