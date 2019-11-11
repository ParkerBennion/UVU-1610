using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SceneController : MonoBehaviour
{
	public string[] shapes = {"circle", "square", "triangle", "octagon"};
void Start ()
	{
		for (int i = 0; i < shapes.Length; i++)
		{
			shapes[i] = shapes[i].ToUpper();
			Debug.Log(shapes[i]);
		}

	}

	void Update () {
		
	}
}
