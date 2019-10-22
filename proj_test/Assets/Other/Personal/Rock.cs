using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Rock : MonoBehaviour
{
	public float gravity = 9.3f;
	public Vector3 place;
	private CharacterController _controller;
	private void Start()
	{
		_controller = GetComponent<CharacterController>();
	}
	void Update () {
		place.y = gravity; // put negative before "=" if your adding jumping.
		
		if (_controller.isGrounded)
		{
			gravity = 0;
		}
		_controller.Move(place*Time.deltaTime);
		
	}
}
