using System;
 using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.WSA.Input;
//co-routines are used to 1. delay events. 2. count anything. 3. load or unload things (garbage collection). 4. anything that needs to repeat (like a gun firing).
public class Coroutines : MonoBehaviour
{
	public UnityEvent startEvent, repeatEvent, endEvent;
	public float seconds = 10f;
	public int counter = 10;
	public bool canRun = true;
	private WaitForSeconds wfsObj; //look up "references" to understand this. its related to variables

	public void Awake()
	{
		StartCoroutine(RunCoroutine());
	}

	IEnumerator RunCoroutine()
	{
		startEvent.Invoke();
		
		while (counter > 0)
		{
			repeatEvent.Invoke();
			yield return wfsObj;
			counter--;
		}

		while (canRun)
		{
			repeatEvent.Invoke();
			yield return wfsObj;
			counter--;
		}

		endEvent.Invoke();
	}
}
