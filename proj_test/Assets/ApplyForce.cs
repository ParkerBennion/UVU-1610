using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
	public Vector3 forces;
	private Rigidbody rb;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision other)
	{
		rb.AddForce(forces);
	}
}
