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
	public UnityEvent Event;
	public UnityEvent stoppingevent;
	

	private void OnTriggerEnter(Collider other)
	{
		print(stringValue);
		Event.Invoke();
		
	}

	private void OnTriggerExit(Collider other)
	{
		stoppingevent.Invoke();
	}

	void Start()
	{

	}

	void Update()
	{

	}
}