using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ParticleControl : MonoBehaviour
{
	public ParticleSystem sparks;


	void Start()
	{
		sparks.Emit(20);
	}

	public void OnMouseDown()
	{
		sparks.Emit(10);
	}
}
