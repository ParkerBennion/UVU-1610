using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{

	public bool appleIsRipe, orangeIsRipe, peachIsRipe;
	
	void Start () {
		if (appleIsRipe)
		{
			print("Go Pick The Apple");
		}	
		else if (orangeIsRipe)
		{
			print("Go Pick The Orange");
		}
		else if (peachIsRipe)
		{
			print("Go Pick The peach");
		}
		else
		{
			print("Nothing Is Ripe");
		}
	}
	void Update () {
		
	}
}
