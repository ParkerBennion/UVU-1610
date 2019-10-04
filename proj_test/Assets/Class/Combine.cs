using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{

	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	// Use this for initialization
	public class ApplyForce : MonoBehaviour
	{
		public Vector3 forces;
		private Rigidbody rb;

		void Start()
		{
			rb = GetComponent<Rigidbody>();
		}

		private void OnCollisionEnter(Collision other)
		{
			rb.AddForce(forces);
		}

		public ParticleSystem sparks;
		public void OnMouseDown()
		{
			sparks.Emit(10);
		}
	}
}
