using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour {
	public ParticleSystem sparks;
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	// Use this for initialization
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
	public void OnMouseDown()
	{
		sparks.Emit(10);
	}
}
