using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitch : MonoBehaviour 
{
	public enum States
	{
		start,
		playing,
		end,
	}

	public States currentState;

	public UnityEvent OnStartEvent, OnPlayingEvent, OnEndEvent;
	
	void Update () 
	{
		switch (currentState)
		{
			case States.start:
				OnStartEvent.Invoke();
				break;
			case States.playing:
				OnPlayingEvent.Invoke();
				break;
			case States.end:
				OnEndEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
