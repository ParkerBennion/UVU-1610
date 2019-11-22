using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SceneController : MonoBehaviour
{
	string[] shapes = {"circle", "square", "triangle", "octagon"};
	public List<string> moreShapes;
	
void Start ()
	{
		moreShapes = new List<string> {"circle", "square", "triangle", "octagon"};
		
		moreShapes.Add("rectangle");
		moreShapes.Insert(2, "diamond");
		moreShapes.Sort();
		for (int i = 0; i < moreShapes.Count; i++)
		{
			moreShapes[i] = moreShapes[i].ToUpper();
			Debug.Log(moreShapes[i]);
		}

	}

void Update () {
		
	}
}
