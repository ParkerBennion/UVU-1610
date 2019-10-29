using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DeBugger : ScriptableObject {

	public void OnDebug(string Words)
	{
		Debug.Log(Words);
	}

	public void OnDebug()
	{
		Debug.Log(name);
	}
}
