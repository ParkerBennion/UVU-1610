using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class flats : MonoBehaviour
{
	public float floatValue = 5.5f;
	public int intValue = 20;
	public int firepower;
	public string stringValue = "bob";
	public string stringValue2 = "hello";
	public UnityEvent Event;
	public UnityEvent stoppingevent;
	public UnityEvent celeron;


	private void OnTriggerEnter(Collider other)
	{
		print(stringValue);
		Event.Invoke();
		
	}

	private void OnTriggerExit(Collider other)
	{
		stoppingevent.Invoke();
		OnEnable(celeron);
		// fiddiling with other commands based on those in lines 33-43. this gave a fatal error.
	}

	//private void OnEnable(Collision other)
	//{
	//	celeron.Invoke();
	//}

	//private void OnDisable(Collision other)
	//{
	//	celeron.Invoke();
	//	print(stringValue2);
	// some commands didnt want to run in unity but the code didnt give a fatial error.
	//}
	

	void Start()
	{

	}

	void Update()
	{

	}
}