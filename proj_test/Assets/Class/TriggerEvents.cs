using System;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(BoxCollider))]
public class TriggerEvents : MonoBehaviour//this is a piece of code already written that allows us to attach code to obj.
//monobehaviours must attach to a game obj.

{
	public UnityEvent triggerEvent;

	private void Awake()
	{
		GetComponent<BoxCollider>().isTrigger = true;
	}

	private void OnTriggerEnter(Collider other)//is triggger needs to be on when collider is used
	{
		triggerEvent.Invoke();//this is configured in the unity editor. this is one of the main things that defines this as scripting.
	}
}
