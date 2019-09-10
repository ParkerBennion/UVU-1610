﻿using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
//monobehaviours must attach to a game obj.
{
	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)//is triggger needs to be on when collider is used
	{
		triggerEvent.Invoke();//this is configured in the unity editor. this is one of the main things that defines this as scripting.
	}
}
